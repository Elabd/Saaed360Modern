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
    public partial class RoadAssistUserVehicleEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.RoadAssistUserVehicle",
                typeof(RoadAssistUserVehicle),
                baseEntityType,
                propertyCount: 8,
                navigationCount: 5,
                foreignKeyCount: 4,
                unnamedIndexCount: 4,
                keyCount: 1);

            var userVehicleId = runtimeEntityType.AddProperty(
                "UserVehicleId",
                typeof(Guid),
                propertyInfo: typeof(RoadAssistUserVehicle).GetProperty("UserVehicleId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUserVehicle).GetField("<UserVehicleId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            userVehicleId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createdByUserId = runtimeEntityType.AddProperty(
                "CreatedByUserId",
                typeof(Guid),
                propertyInfo: typeof(RoadAssistUserVehicle).GetProperty("CreatedByUserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUserVehicle).GetField("<CreatedByUserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            createdByUserId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime),
                propertyInfo: typeof(RoadAssistUserVehicle).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUserVehicle).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            creationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool),
                propertyInfo: typeof(RoadAssistUserVehicle).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUserVehicle).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastModificationDate = runtimeEntityType.AddProperty(
                "LastModificationDate",
                typeof(DateTime?),
                propertyInfo: typeof(RoadAssistUserVehicle).GetProperty("LastModificationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUserVehicle).GetField("<LastModificationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastModificationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastModifiedByUserId = runtimeEntityType.AddProperty(
                "LastModifiedByUserId",
                typeof(Guid?),
                propertyInfo: typeof(RoadAssistUserVehicle).GetProperty("LastModifiedByUserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUserVehicle).GetField("<LastModifiedByUserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastModifiedByUserId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var userId = runtimeEntityType.AddProperty(
                "UserId",
                typeof(Guid),
                propertyInfo: typeof(RoadAssistUserVehicle).GetProperty("UserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUserVehicle).GetField("<UserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            userId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var vehicleId = runtimeEntityType.AddProperty(
                "VehicleId",
                typeof(Guid),
                propertyInfo: typeof(RoadAssistUserVehicle).GetProperty("VehicleId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUserVehicle).GetField("<VehicleId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            vehicleId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { userVehicleId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__RoadAssi__A7F4C099A029EB62");

            var index = runtimeEntityType.AddIndex(
                new[] { createdByUserId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { lastModifiedByUserId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { userId });

            var index2 = runtimeEntityType.AddIndex(
                new[] { vehicleId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("CreatedByUserId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("UserId") }),
                principalEntityType,
                required: true);

            var createdByUser = declaringEntityType.AddNavigation("CreatedByUser",
                runtimeForeignKey,
                onDependent: true,
                typeof(RoadAssistUser),
                propertyInfo: typeof(RoadAssistUserVehicle).GetProperty("CreatedByUser", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUserVehicle).GetField("<CreatedByUser>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var roadAssistUserVehicleCreatedByUsers = principalEntityType.AddNavigation("RoadAssistUserVehicleCreatedByUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RoadAssistUserVehicle>),
                propertyInfo: typeof(RoadAssistUser).GetProperty("RoadAssistUserVehicleCreatedByUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUser).GetField("<RoadAssistUserVehicleCreatedByUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RoadAssis__Creat__3BB20799");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("LastModifiedByUserId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("UserId") }),
                principalEntityType);

            var lastModifiedByUser = declaringEntityType.AddNavigation("LastModifiedByUser",
                runtimeForeignKey,
                onDependent: true,
                typeof(RoadAssistUser),
                propertyInfo: typeof(RoadAssistUserVehicle).GetProperty("LastModifiedByUser", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUserVehicle).GetField("<LastModifiedByUser>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var roadAssistUserVehicleLastModifiedByUsers = principalEntityType.AddNavigation("RoadAssistUserVehicleLastModifiedByUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RoadAssistUserVehicle>),
                propertyInfo: typeof(RoadAssistUser).GetProperty("RoadAssistUserVehicleLastModifiedByUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUser).GetField("<RoadAssistUserVehicleLastModifiedByUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RoadAssis__LastM__3CA62BD2");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("UserId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("UserId") }),
                principalEntityType,
                required: true);

            var user = declaringEntityType.AddNavigation("User",
                runtimeForeignKey,
                onDependent: true,
                typeof(RoadAssistUser),
                propertyInfo: typeof(RoadAssistUserVehicle).GetProperty("User", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUserVehicle).GetField("<User>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var roadAssistUserVehicleUsers = principalEntityType.AddNavigation("RoadAssistUserVehicleUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RoadAssistUserVehicle>),
                propertyInfo: typeof(RoadAssistUser).GetProperty("RoadAssistUserVehicleUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUser).GetField("<RoadAssistUserVehicleUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RoadAssis__UserI__3D9A500B");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("VehicleId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("VehicleId") }),
                principalEntityType,
                required: true);

            var vehicle = declaringEntityType.AddNavigation("Vehicle",
                runtimeForeignKey,
                onDependent: true,
                typeof(RoadAssistVehicle),
                propertyInfo: typeof(RoadAssistUserVehicle).GetProperty("Vehicle", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUserVehicle).GetField("<Vehicle>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var roadAssistUserVehicles = principalEntityType.AddNavigation("RoadAssistUserVehicles",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RoadAssistUserVehicle>),
                propertyInfo: typeof(RoadAssistVehicle).GetProperty("RoadAssistUserVehicles", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistVehicle).GetField("<RoadAssistUserVehicles>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RoadAssis__Vehic__3E8E7444");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "RoadAssistUserVehicle");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
