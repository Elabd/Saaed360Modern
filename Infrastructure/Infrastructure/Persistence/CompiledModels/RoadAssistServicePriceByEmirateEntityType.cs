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
    public partial class RoadAssistServicePriceByEmirateEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.RoadAssistServicePriceByEmirate",
                typeof(RoadAssistServicePriceByEmirate),
                baseEntityType,
                propertyCount: 12,
                navigationCount: 5,
                foreignKeyCount: 4,
                unnamedIndexCount: 4,
                keyCount: 1);

            var servicePriceByEmirateId = runtimeEntityType.AddProperty(
                "ServicePriceByEmirateId",
                typeof(Guid),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("ServicePriceByEmirateId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<ServicePriceByEmirateId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            servicePriceByEmirateId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createdByUserId = runtimeEntityType.AddProperty(
                "CreatedByUserId",
                typeof(Guid),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("CreatedByUserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<CreatedByUserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            createdByUserId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            creationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var distinationEmirateId = runtimeEntityType.AddProperty(
                "DistinationEmirateId",
                typeof(long),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("DistinationEmirateId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<DistinationEmirateId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            distinationEmirateId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var effectiveEndDate = runtimeEntityType.AddProperty(
                "EffectiveEndDate",
                typeof(DateTime?),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("EffectiveEndDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<EffectiveEndDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            effectiveEndDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var effectiveStartDate = runtimeEntityType.AddProperty(
                "EffectiveStartDate",
                typeof(DateTime),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("EffectiveStartDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<EffectiveStartDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            effectiveStartDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var goingPrice = runtimeEntityType.AddProperty(
                "GoingPrice",
                typeof(decimal?),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("GoingPrice", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<GoingPrice>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            goingPrice.AddAnnotation("Relational:ColumnType", "decimal(18, 3)");
            goingPrice.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastModificationDate = runtimeEntityType.AddProperty(
                "LastModificationDate",
                typeof(DateTime?),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("LastModificationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<LastModificationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastModificationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastModifiedByUserId = runtimeEntityType.AddProperty(
                "LastModifiedByUserId",
                typeof(Guid?),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("LastModifiedByUserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<LastModifiedByUserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastModifiedByUserId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var providerServiceId = runtimeEntityType.AddProperty(
                "ProviderServiceId",
                typeof(Guid?),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("ProviderServiceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<ProviderServiceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            providerServiceId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var returningPrice = runtimeEntityType.AddProperty(
                "ReturningPrice",
                typeof(decimal?),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("ReturningPrice", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<ReturningPrice>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            returningPrice.AddAnnotation("Relational:ColumnType", "decimal(18, 3)");
            returningPrice.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { servicePriceByEmirateId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__RoadAssi__ACC36E2CE5690FBB");

            var index = runtimeEntityType.AddIndex(
                new[] { createdByUserId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { distinationEmirateId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { lastModifiedByUserId });

            var index2 = runtimeEntityType.AddIndex(
                new[] { providerServiceId });

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
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("CreatedByUser", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<CreatedByUser>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var roadAssistServicePriceByEmirateCreatedByUsers = principalEntityType.AddNavigation("RoadAssistServicePriceByEmirateCreatedByUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RoadAssistServicePriceByEmirate>),
                propertyInfo: typeof(RoadAssistUser).GetProperty("RoadAssistServicePriceByEmirateCreatedByUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUser).GetField("<RoadAssistServicePriceByEmirateCreatedByUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RoadAssis__Creat__2D63E842");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DistinationEmirateId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("EmirateId") }),
                principalEntityType,
                required: true);

            var distinationEmirate = declaringEntityType.AddNavigation("DistinationEmirate",
                runtimeForeignKey,
                onDependent: true,
                typeof(EmirateDim),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("DistinationEmirate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<DistinationEmirate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var roadAssistServicePriceByEmirates = principalEntityType.AddNavigation("RoadAssistServicePriceByEmirates",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RoadAssistServicePriceByEmirate>),
                propertyInfo: typeof(EmirateDim).GetProperty("RoadAssistServicePriceByEmirates", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EmirateDim).GetField("<RoadAssistServicePriceByEmirates>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RoadAssis__Disti__2E580C7B");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("LastModifiedByUserId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("UserId") }),
                principalEntityType);

            var lastModifiedByUser = declaringEntityType.AddNavigation("LastModifiedByUser",
                runtimeForeignKey,
                onDependent: true,
                typeof(RoadAssistUser),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("LastModifiedByUser", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<LastModifiedByUser>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var roadAssistServicePriceByEmirateLastModifiedByUsers = principalEntityType.AddNavigation("RoadAssistServicePriceByEmirateLastModifiedByUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RoadAssistServicePriceByEmirate>),
                propertyInfo: typeof(RoadAssistUser).GetProperty("RoadAssistServicePriceByEmirateLastModifiedByUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUser).GetField("<RoadAssistServicePriceByEmirateLastModifiedByUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RoadAssis__LastM__2F4C30B4");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ProviderServiceId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ProviderServiceId") }),
                principalEntityType);

            var providerService = declaringEntityType.AddNavigation("ProviderService",
                runtimeForeignKey,
                onDependent: true,
                typeof(RoadAssistProviderService),
                propertyInfo: typeof(RoadAssistServicePriceByEmirate).GetProperty("ProviderService", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistServicePriceByEmirate).GetField("<ProviderService>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var roadAssistServicePriceByEmirates = principalEntityType.AddNavigation("RoadAssistServicePriceByEmirates",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RoadAssistServicePriceByEmirate>),
                propertyInfo: typeof(RoadAssistProviderService).GetProperty("RoadAssistServicePriceByEmirates", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistProviderService).GetField("<RoadAssistServicePriceByEmirates>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RoadAssis__Provi__00272D77");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "RoadAssistServicePriceByEmirate");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
