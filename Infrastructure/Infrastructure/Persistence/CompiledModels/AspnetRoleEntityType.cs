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
    public partial class AspnetRoleEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.AspnetRole",
                typeof(AspnetRole),
                baseEntityType,
                propertyCount: 13,
                navigationCount: 12,
                foreignKeyCount: 4,
                unnamedIndexCount: 3,
                namedIndexCount: 1,
                keyCount: 1);

            var roleId = runtimeEntityType.AddProperty(
                "RoleId",
                typeof(Guid),
                propertyInfo: typeof(AspnetRole).GetProperty("RoleId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<RoleId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            roleId.AddAnnotation("Relational:DefaultValueSql", "(newid())");
            roleId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var applicationId = runtimeEntityType.AddProperty(
                "ApplicationId",
                typeof(Guid),
                propertyInfo: typeof(AspnetRole).GetProperty("ApplicationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<ApplicationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            applicationId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(Guid?),
                propertyInfo: typeof(AspnetRole).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            createdBy.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var creationTime = runtimeEntityType.AddProperty(
                "CreationTime",
                typeof(DateTime?),
                propertyInfo: typeof(AspnetRole).GetProperty("CreationTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<CreationTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationTime.AddAnnotation("Relational:ColumnType", "datetime");
            creationTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var defaultPageId = runtimeEntityType.AddProperty(
                "DefaultPageId",
                typeof(long?),
                propertyInfo: typeof(AspnetRole).GetProperty("DefaultPageId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<DefaultPageId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            defaultPageId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(AspnetRole).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 256);
            description.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(long),
                propertyInfo: typeof(AspnetRole).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: 0L);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool?),
                propertyInfo: typeof(AspnetRole).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isSuperAdmin = runtimeEntityType.AddProperty(
                "IsSuperAdmin",
                typeof(bool?),
                propertyInfo: typeof(AspnetRole).GetProperty("IsSuperAdmin", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<IsSuperAdmin>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isSuperAdmin.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastModifiedDate = runtimeEntityType.AddProperty(
                "LastModifiedDate",
                typeof(DateTime?),
                propertyInfo: typeof(AspnetRole).GetProperty("LastModifiedDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<LastModifiedDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastModifiedDate.AddAnnotation("Relational:ColumnType", "datetime");
            lastModifiedDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var loweredRoleName = runtimeEntityType.AddProperty(
                "LoweredRoleName",
                typeof(string),
                propertyInfo: typeof(AspnetRole).GetProperty("LoweredRoleName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<LoweredRoleName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 256);
            loweredRoleName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var parentRoleId = runtimeEntityType.AddProperty(
                "ParentRoleId",
                typeof(Guid?),
                propertyInfo: typeof(AspnetRole).GetProperty("ParentRoleId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<ParentRoleId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            parentRoleId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var roleName = runtimeEntityType.AddProperty(
                "RoleName",
                typeof(string),
                propertyInfo: typeof(AspnetRole).GetProperty("RoleName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<RoleName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 256);
            roleName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { roleId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__aspnet_R__8AFACE1B3E9EBED5");

            var index = runtimeEntityType.AddIndex(
                new[] { createdBy });

            var index0 = runtimeEntityType.AddIndex(
                new[] { defaultPageId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { parentRoleId });

            var aspnet_Roles_index1 = runtimeEntityType.AddIndex(
                new[] { applicationId, loweredRoleName },
                name: "aspnet_Roles_index1",
                unique: true);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ApplicationId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ApplicationId") }),
                principalEntityType,
                required: true);

            var application = declaringEntityType.AddNavigation("Application",
                runtimeForeignKey,
                onDependent: true,
                typeof(AspnetApplication),
                propertyInfo: typeof(AspnetRole).GetProperty("Application", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<Application>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var aspnetRoles = principalEntityType.AddNavigation("AspnetRoles",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<AspnetRole>),
                propertyInfo: typeof(AspnetApplication).GetProperty("AspnetRoles", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetApplication).GetField("<AspnetRoles>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__aspnet_Ro__Appli__021EF521");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("CreatedBy") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("UserId") }),
                principalEntityType);

            var createdByNavigation = declaringEntityType.AddNavigation("CreatedByNavigation",
                runtimeForeignKey,
                onDependent: true,
                typeof(AspnetUser),
                propertyInfo: typeof(AspnetRole).GetProperty("CreatedByNavigation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<CreatedByNavigation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var aspnetRoles = principalEntityType.AddNavigation("AspnetRoles",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<AspnetRole>),
                propertyInfo: typeof(AspnetUser).GetProperty("AspnetRoles", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetUser).GetField("<AspnetRoles>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_aspnet_Roles_aspnet_Users");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DefaultPageId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType);

            var defaultPage = declaringEntityType.AddNavigation("DefaultPage",
                runtimeForeignKey,
                onDependent: true,
                typeof(ApplicationPage),
                propertyInfo: typeof(AspnetRole).GetProperty("DefaultPage", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<DefaultPage>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var aspnetRoles = principalEntityType.AddNavigation("AspnetRoles",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<AspnetRole>),
                propertyInfo: typeof(ApplicationPage).GetProperty("AspnetRoles", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ApplicationPage).GetField("<AspnetRoles>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_aspnet_Roles_ApplicationPages");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ParentRoleId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("RoleId") }),
                principalEntityType);

            var parentRole = declaringEntityType.AddNavigation("ParentRole",
                runtimeForeignKey,
                onDependent: true,
                typeof(AspnetRole),
                propertyInfo: typeof(AspnetRole).GetProperty("ParentRole", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<ParentRole>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var inverseParentRole = principalEntityType.AddNavigation("InverseParentRole",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<AspnetRole>),
                propertyInfo: typeof(AspnetRole).GetProperty("InverseParentRole", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AspnetRole).GetField("<InverseParentRole>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_aspnet_Roles_aspnet_Roles");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "aspnet_Roles");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
