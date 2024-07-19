﻿using System.Threading.Tasks;
using Melia.Shared.Game.Const;
using Melia.Zone.Network;
using Melia.Zone.World.Actors;
using Melia.Zone.World.Actors.Characters;
using Melia.Zone.World.Actors.CombatEntities.Components;
using Melia.Zone.World.Actors.Monsters;
using Melia.Zone.World.Actors.Pads;

namespace Melia.Zone.Pads.Handlers.Swordsman.Peltasta
{
	/// <summary>
	/// Handler for the Shield Lob pad, spawning a shield modeled after the
	/// caster's shield, that flies forward and then back, Captain America
	/// style.
	/// </summary>
	[PadHandler("Peltasta_ShieldLob")]
	public class Peltasta_ShieldLob : ICreatePadHandler, IDestroyPadHandler
	{
		private const float ShieldFlyDistance = 100;
		private const float ShieldFlySpeedForward = 150;

		/// <summary>
		/// Called when the pad is created.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Created(object sender, TriggerArgs args)
		{
			var pad = args.Trigger as Pad;
			var creator = pad.Creator as ICombatEntity;
			var skill = pad.Skill;

			pad.Movement.Speed = ShieldFlySpeedForward;
			pad.Trigger.MaxActorCount = 8;

			//if (creator.Map.IsPvp)
			//	pad.Trigger.ActorMaxCount = 4;

			var shieldMonster = new Mob(57001, MonsterType.Friendly);

			shieldMonster.Position = creator.Position.GetRelative(creator.Direction, 25f);
			shieldMonster.Direction = creator.Direction;
			shieldMonster.FromGround = false;
			shieldMonster.Components.Add(new MovementComponent(shieldMonster));

			Send.ZC_NORMAL.SkillPad(creator, skill, "Peltasta_ShieldLob2", shieldMonster.Position, shieldMonster.Direction, -0.7853982f, 0, pad.Handle, 30, true);
			creator.Map.AddMonster(shieldMonster);

			if (creator is Character character)
			{
				var lhItem = character.Inventory.GetItem(EquipSlot.LeftHand).Data;
				Send.ZC_NORMAL.SetPadModel(shieldMonster, "warrior_f_", lhItem.Id);
			}

			Send.ZC_NORMAL.SkillItemRotate(shieldMonster, 90, 0, 0);
			Send.ZC_NORMAL.SpinObject(shieldMonster);
			Send.ZC_NORMAL.SkillSetActorHeight(shieldMonster, pad.Handle, 22);
			Send.ZC_NORMAL.AttachEffect(shieldMonster, "I_light004_violet", 1.5f);

			pad.Variables.Set("shieldMonster", shieldMonster);

			this.FlyShieldFly(pad, creator);
		}

		/// <summary>
		/// Called when the pad is destroyed.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="args"></param>
		public void Destroyed(object sender, TriggerArgs args)
		{
			var pad = args.Trigger as Pad;
			var creator = pad.Creator as ICombatEntity;
			var skill = pad.Skill;
			var shieldMonster = pad.Variables.Get<Mob>("shieldMonster");

			Send.ZC_NORMAL.SkillPad(creator, skill, "Peltasta_ShieldLob2", creator.Position, creator.Direction, 0, 145.8735f, pad.Handle, 30, false);
			creator.Map.RemoveMonster(shieldMonster);
		}

		/// <summary>
		/// Makes shield fly forward, away from the caster, and then back.
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="creator"></param>
		private async void FlyShieldFly(Pad pad, ICombatEntity creator)
		{
			// Forward and back, hovering a moment in between.
			await this.FlyForward(pad, creator);
			await Task.Delay(500);
			await this.FlyBack(pad, creator);

			pad.Destroy();
		}

		/// <summary>
		/// Makes shield fly a certain distance forward, in the direction the
		/// creator is facing.
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="creator"></param>
		/// <returns></returns>
		private async Task FlyForward(Pad pad, ICombatEntity creator)
		{
			var dest = creator.Position.GetRelative(creator.Direction, ShieldFlyDistance);
			var moveTime = pad.Movement.MoveTo(dest);
			await Task.Delay(moveTime);
		}

		/// <summary>
		/// Makes shield fly back to the creator.
		/// </summary>
		/// <param name="pad"></param>
		/// <param name="creator"></param>
		/// <returns></returns>
		private async Task FlyBack(Pad pad, ICombatEntity creator)
		{
			var moveTime = pad.Movement.MoveTo(creator.Position);
			await Task.Delay(moveTime);
		}
	}
}