﻿using System.Collections.Generic;
using Melia.Shared.Network;

namespace Melia.Social.Database
{
	/// <summary>
	/// Represents a chat room.
	/// </summary>
	public class ChatRoom
	{
		public readonly List<ChatRoomMember> _members = new List<ChatRoomMember>();
		public readonly List<ChatMessage> _messages = new List<ChatMessage>();

		/// <summary>
		/// Returns the chat room's globally unique id.
		/// </summary>
		public long Id { get; }

		/// <summary>
		/// Get or set the chat room's name.
		/// </summary>
		public string Name { get; set; } = "";

		/// <summary>
		/// Returns the chat room's type.
		/// </summary>
		public ChatRoomType Type { get; set; } = ChatRoomType.Group;

		/// <summary>
		/// Returns the account id of the chat room's owner.
		/// </summary>
		public long OwnerId { get; set; }

		/// <summary>
		/// Returns the number of members in the chat room.
		/// </summary>
		public int MemberCount
		{
			get
			{
				lock (_members)
					return _members.Count;
			}
		}

		/// <summary>
		/// Creates new chat room.
		/// </summary>
		/// <param name="name"></param>
		/// <param name="type"></param>
		/// <param name="owner"></param>
		public ChatRoom(string name, ChatRoomType type, Account owner)
		{
			this.Id = SocialServer.Instance.ChatManager.GetNewChatId();

			this.Name = name;
			this.Type = type;
			this.OwnerId = owner.Id;
		}

		/// <summary>
		/// Returns list of all members in the chat room.
		/// </summary>
		/// <returns></returns>
		public ChatRoomMember[] GetMembers()
		{
			lock (_members)
				return _members.ToArray();
		}

		/// <summary>
		/// Returns list of all messages in the chat room.
		/// </summary>
		/// <returns></returns>
		public ChatMessage[] GetMessages()
		{
			lock (_messages)
				return _messages.ToArray();
		}

		/// <summary>
		/// Add a member to the chat room.
		/// </summary>
		/// <param name="member"></param>
		public void AddMember(Account account)
			=> this.AddMember(new ChatRoomMember(this.Id, account.Id, account.TeamName));

		/// <summary>
		/// Add a member to the chat room.
		/// </summary>
		/// <param name="member"></param>
		public void AddMember(ChatRoomMember member)
		{
			lock (_members)
				_members.Add(member);
		}

		/// <summary>
		/// Removes a member from a chat room.
		/// </summary>
		/// <param name="accountId"></param>
		public void RemoveMember(long accountId)
		{
			lock (_members)
				_members.RemoveAll(m => m.AccountId == accountId);
		}

		/// <summary>
		/// Add a message to the chat room.
		/// </summary>
		/// <param name="message"></param>
		public void AddMessage(ChatMessage message)
		{
			lock (_messages)
				_messages.Add(message);
		}

		/// <summary>
		/// Broadcasts packet to all members of the room who are online.
		/// </summary>
		/// <param name="packet"></param>
		public virtual void Broadcast(Packet packet)
		{
			lock (_members)
			{
				foreach (var account in _members)
				{
					if (SocialServer.Instance.UserManager.TryGet(account.AccountId, out var user))
						user.Connection.Send(packet);
				}
			}
		}
	}

	/// <summary>
	/// Specifies a chat room's type.
	/// </summary>
	public enum ChatRoomType
	{
		/// <summary>
		/// The chat is between two users.
		/// </summary>
		OneToOne = 0,

		/// <summary>
		/// The chat is between friends?
		/// </summary>
		Friends = 1,

		/// <summary>
		/// The chat is between a group of users.
		/// </summary>
		Group = 3,
	}
}
