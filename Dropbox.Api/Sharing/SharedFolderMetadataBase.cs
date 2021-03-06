// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>Properties of the shared folder.</para>
    /// </summary>
    /// <seealso cref="SharedFolderMetadata" />
    public class SharedFolderMetadataBase
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SharedFolderMetadataBase> Encoder = new SharedFolderMetadataBaseEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SharedFolderMetadataBase> Decoder = new SharedFolderMetadataBaseDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderMetadataBase" />
        /// class.</para>
        /// </summary>
        /// <param name="accessType">The current user's access level for this shared
        /// folder.</param>
        /// <param name="isTeamFolder">Whether this folder is a <a
        /// href="https://www.dropbox.com/en/help/986">team folder</a>.</param>
        /// <param name="policy">Policies governing this shared folder.</param>
        /// <param name="ownerTeam">The team that owns the folder. This field is not present if
        /// the folder is not owned by a team.</param>
        /// <param name="parentSharedFolderId">The ID of the parent shared folder. This field
        /// is present only if the folder is contained within another shared folder.</param>
        public SharedFolderMetadataBase(AccessLevel accessType,
                                        bool isTeamFolder,
                                        FolderPolicy policy,
                                        Dropbox.Api.Users.Team ownerTeam = null,
                                        string parentSharedFolderId = null)
        {
            if (accessType == null)
            {
                throw new sys.ArgumentNullException("accessType");
            }

            if (policy == null)
            {
                throw new sys.ArgumentNullException("policy");
            }

            if (parentSharedFolderId != null)
            {
                if (!re.Regex.IsMatch(parentSharedFolderId, @"\A(?:[-_0-9a-zA-Z:]+)\z"))
                {
                    throw new sys.ArgumentOutOfRangeException("parentSharedFolderId", @"Value should match pattern '\A(?:[-_0-9a-zA-Z:]+)\z'");
                }
            }

            this.AccessType = accessType;
            this.IsTeamFolder = isTeamFolder;
            this.Policy = policy;
            this.OwnerTeam = ownerTeam;
            this.ParentSharedFolderId = parentSharedFolderId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SharedFolderMetadataBase" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public SharedFolderMetadataBase()
        {
        }

        /// <summary>
        /// <para>The current user's access level for this shared folder.</para>
        /// </summary>
        public AccessLevel AccessType { get; protected set; }

        /// <summary>
        /// <para>Whether this folder is a <a href="https://www.dropbox.com/en/help/986">team
        /// folder</a>.</para>
        /// </summary>
        public bool IsTeamFolder { get; protected set; }

        /// <summary>
        /// <para>Policies governing this shared folder.</para>
        /// </summary>
        public FolderPolicy Policy { get; protected set; }

        /// <summary>
        /// <para>The team that owns the folder. This field is not present if the folder is not
        /// owned by a team.</para>
        /// </summary>
        public Dropbox.Api.Users.Team OwnerTeam { get; protected set; }

        /// <summary>
        /// <para>The ID of the parent shared folder. This field is present only if the folder
        /// is contained within another shared folder.</para>
        /// </summary>
        public string ParentSharedFolderId { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SharedFolderMetadataBase" />.</para>
        /// </summary>
        private class SharedFolderMetadataBaseEncoder : enc.StructEncoder<SharedFolderMetadataBase>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SharedFolderMetadataBase value, enc.IJsonWriter writer)
            {
                WriteProperty("access_type", value.AccessType, writer, Dropbox.Api.Sharing.AccessLevel.Encoder);
                WriteProperty("is_team_folder", value.IsTeamFolder, writer, enc.BooleanEncoder.Instance);
                WriteProperty("policy", value.Policy, writer, Dropbox.Api.Sharing.FolderPolicy.Encoder);
                if (value.OwnerTeam != null)
                {
                    WriteProperty("owner_team", value.OwnerTeam, writer, Dropbox.Api.Users.Team.Encoder);
                }
                if (value.ParentSharedFolderId != null)
                {
                    WriteProperty("parent_shared_folder_id", value.ParentSharedFolderId, writer, enc.StringEncoder.Instance);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SharedFolderMetadataBase" />.</para>
        /// </summary>
        private class SharedFolderMetadataBaseDecoder : enc.StructDecoder<SharedFolderMetadataBase>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SharedFolderMetadataBase"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SharedFolderMetadataBase Create()
            {
                return new SharedFolderMetadataBase();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SharedFolderMetadataBase value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "access_type":
                        value.AccessType = Dropbox.Api.Sharing.AccessLevel.Decoder.Decode(reader);
                        break;
                    case "is_team_folder":
                        value.IsTeamFolder = enc.BooleanDecoder.Instance.Decode(reader);
                        break;
                    case "policy":
                        value.Policy = Dropbox.Api.Sharing.FolderPolicy.Decoder.Decode(reader);
                        break;
                    case "owner_team":
                        value.OwnerTeam = Dropbox.Api.Users.Team.Decoder.Decode(reader);
                        break;
                    case "parent_shared_folder_id":
                        value.ParentSharedFolderId = enc.StringDecoder.Instance.Decode(reader);
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
