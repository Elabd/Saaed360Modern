﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Infrastructure.Persistence.CompiledModels
{
    [EntityFrameworkInternal]
    public partial class InternalUserPasswordChangeHistoryEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.InternalUserPasswordChangeHistory",
                typeof(InternalUserPasswordChangeHistory),
                baseEntityType,
                propertyCount: 6,
                navigationCount: 1,
                foreignKeyCount: 1,
                namedIndexCount: 5,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(long),
                propertyInfo: typeof(InternalUserPasswordChangeHistory).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(InternalUserPasswordChangeHistory).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var changeDate = runtimeEntityType.AddProperty(
                "ChangeDate",
                typeof(DateTime),
                propertyInfo: typeof(InternalUserPasswordChangeHistory).GetProperty("ChangeDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(InternalUserPasswordChangeHistory).GetField("<ChangeDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            changeDate.AddAnnotation("Relational:ColumnType", "datetime");
            changeDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isInitiate = runtimeEntityType.AddProperty(
                "IsInitiate",
                typeof(bool),
                propertyInfo: typeof(InternalUserPasswordChangeHistory).GetProperty("IsInitiate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(InternalUserPasswordChangeHistory).GetField("<IsInitiate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isInitiate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var passwordHash = runtimeEntityType.AddProperty(
                "PasswordHash",
                typeof(string),
                propertyInfo: typeof(InternalUserPasswordChangeHistory).GetProperty("PasswordHash", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(InternalUserPasswordChangeHistory).GetField("<PasswordHash>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 150,
                unicode: false);
            passwordHash.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var salt = runtimeEntityType.AddProperty(
                "Salt",
                typeof(string),
                propertyInfo: typeof(InternalUserPasswordChangeHistory).GetProperty("Salt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(InternalUserPasswordChangeHistory).GetField("<Salt>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50,
                unicode: false);
            salt.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var userId = runtimeEntityType.AddProperty(
                "UserId",
                typeof(Guid),
                propertyInfo: typeof(InternalUserPasswordChangeHistory).GetProperty("UserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(InternalUserPasswordChangeHistory).GetField("<UserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            userId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__Internal__3214EC07DC22382F");

            var iX_InternalUserPasswordChangeHistory_ChangeDate = runtimeEntityType.AddIndex(
                new[] { changeDate },
                name: "IX_InternalUserPasswordChangeHistory_ChangeDate");

            var iX_InternalUserPasswordChangeHistory_UserId = runtimeEntityType.AddIndex(
                new[] { userId },
                name: "IX_InternalUserPasswordChangeHistory_UserId");

            var iX_InternalUserPasswordChangeHistory_UserId_ChangeDate = runtimeEntityType.AddIndex(
                new[] { userId, changeDate },
                name: "IX_InternalUserPasswordChangeHistory_UserId_ChangeDate");

            var iX_InternalUserPasswordChangeHistory_UserId_ChangeDate_Include = runtimeEntityType.AddIndex(
                new[] { userId, changeDate },
                name: "IX_InternalUserPasswordChangeHistory_UserId_ChangeDate_Include");

            var iX_InternalUserPasswordChangeHistory_UserId_Include = runtimeEntityType.AddIndex(
                new[] { userId },
                name: "IX_InternalUserPasswordChangeHistory_UserId_Include");

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("UserId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("UserId") }),
                principalEntityType,
                required: true);

            var user = declaringEntityType.AddNavigation("User",
                runtimeForeignKey,
                onDependent: true,
                typeof(AspnetUser),
                propertyInfo: typeof(InternalUserPasswordChangeHistory).GetProperty("User", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(InternalUserPasswordChangeHistory).GetField("<User>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var internalUserPasswordChangeHistories = principalEntityType.AddNavigation("InternalUserPasswordChangeHistories",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<InternalUserPasswordChangeHistory>),
                propertyInfo: typeof(AspnetUser).GetProperty("InternalUserPasswordChangeHistories", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetUser).GetField("<InternalUserPasswordChangeHistories>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_InternalUserPasswordChangeHistory_AspUser");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "InternalUserPasswordChangeHistory");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
