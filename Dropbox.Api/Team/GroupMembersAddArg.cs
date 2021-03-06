// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Team
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The group members add arg object</para>
    /// </summary>
    /// <seealso cref="Dropbox.Api.Team.IncludeMembersArg" />
    public class GroupMembersAddArg : IncludeMembersArg
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<GroupMembersAddArg> Encoder = new GroupMembersAddArgEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<GroupMembersAddArg> Decoder = new GroupMembersAddArgDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupMembersAddArg" />
        /// class.</para>
        /// </summary>
        /// <param name="group">Group to which users will be added.</param>
        /// <param name="members">List of users to be added to the group.</param>
        /// <param name="returnMembers">Whether to return the list of members in the group.
        /// Note that the default value will cause all the group members  to be returned in the
        /// response. This may take a long time for large groups.</param>
        public GroupMembersAddArg(GroupSelector @group,
                                  col.IEnumerable<MemberAccess> members,
                                  bool returnMembers = true)
            : base(returnMembers)
        {
            if (@group == null)
            {
                throw new sys.ArgumentNullException("@group");
            }

            var membersList = enc.Util.ToList(members);

            if (members == null)
            {
                throw new sys.ArgumentNullException("members");
            }

            this.Group = @group;
            this.Members = membersList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GroupMembersAddArg" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GroupMembersAddArg()
        {
        }

        /// <summary>
        /// <para>Group to which users will be added.</para>
        /// </summary>
        public GroupSelector Group { get; protected set; }

        /// <summary>
        /// <para>List of users to be added to the group.</para>
        /// </summary>
        public col.IList<MemberAccess> Members { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="GroupMembersAddArg" />.</para>
        /// </summary>
        private class GroupMembersAddArgEncoder : enc.StructEncoder<GroupMembersAddArg>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(GroupMembersAddArg value, enc.IJsonWriter writer)
            {
                WriteProperty("group", value.Group, writer, Dropbox.Api.Team.GroupSelector.Encoder);
                WriteListProperty("members", value.Members, writer, Dropbox.Api.Team.MemberAccess.Encoder);
                WriteProperty("return_members", value.ReturnMembers, writer, enc.BooleanEncoder.Instance);
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="GroupMembersAddArg" />.</para>
        /// </summary>
        private class GroupMembersAddArgDecoder : enc.StructDecoder<GroupMembersAddArg>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="GroupMembersAddArg" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override GroupMembersAddArg Create()
            {
                return new GroupMembersAddArg();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(GroupMembersAddArg value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "group":
                        value.Group = Dropbox.Api.Team.GroupSelector.Decoder.Decode(reader);
                        break;
                    case "members":
                        value.Members = ReadList<MemberAccess>(reader, Dropbox.Api.Team.MemberAccess.Decoder);
                        break;
                    case "return_members":
                        value.ReturnMembers = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
