﻿using Umbraco.Core.Persistence;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace Umbraco.Core.Models.Rdbms
{
    [TableName("umbracoUser")]
    [PrimaryKey("id")]
    [ExplicitColumns]
    internal class UserDto
    {
        [Column("id")]
        [PrimaryKeyColumn]
        public int Id { get; set; }

        [Column("userDisabled")]
        [Constraint(Default = "0")]
        public bool Disabled { get; set; }

        [Column("userNoConsole")]
        [Constraint(Default = "0")]
        public bool NoConsole { get; set; }

        [Column("userType")]
        [ForeignKey(typeof(UserTypeDto))]
        public short Type { get; set; }

        [Column("startStructureID")]
        public int ContentStartId { get; set; }

        [Column("startMediaID")]
        [NullSetting(NullSetting = NullSettings.Null)]
        public int? MediaStartId { get; set; }

        [Column("userName")]
        public string UserName { get; set; }

        [Column("userLogin")]
        [DatabaseType(SpecialDbTypes.NVARCHAR, Length = 125)]
        [Index(IndexTypes.NonClustered)]
        public string Login { get; set; }

        [Column("userPassword")]
        [DatabaseType(SpecialDbTypes.NVARCHAR, Length = 125)]
        public string Password { get; set; }

        [Column("userEmail")]
        public string Email { get; set; }

        [Column("userDefaultPermissions")]
        [NullSetting(NullSetting = NullSettings.Null)]
        [DatabaseType(SpecialDbTypes.NVARCHAR, Length = 50)]
        public string DefaultPermissions { get; set; }

        [Column("userLanguage")]
        [NullSetting(NullSetting = NullSettings.Null)]
        [DatabaseType(SpecialDbTypes.NVARCHAR, Length = 10)]
        public string UserLanguage { get; set; }

        [Column("defaultToLiveEditing")]
        [Constraint(Default = "0")]
        public bool DefaultToLiveEditing { get; set; }
    }
}