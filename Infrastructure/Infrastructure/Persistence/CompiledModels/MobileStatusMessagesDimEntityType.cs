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
    public partial class MobileStatusMessagesDimEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.MobileStatusMessagesDim",
                typeof(MobileStatusMessagesDim),
                baseEntityType,
                propertyCount: 6,
                navigationCount: 2,
                foreignKeyCount: 2,
                unnamedIndexCount: 2,
                keyCount: 1);

            var mobileStatusMessageId = runtimeEntityType.AddProperty(
                "MobileStatusMessageId",
                typeof(int),
                propertyInfo: typeof(MobileStatusMessagesDim).GetProperty("MobileStatusMessageId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileStatusMessagesDim).GetField("<MobileStatusMessageId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            mobileStatusMessageId.AddAnnotation("Relational:ColumnName", "MobileStatusMessageID");
            mobileStatusMessageId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var activityReasonId = runtimeEntityType.AddProperty(
                "ActivityReasonId",
                typeof(int?),
                propertyInfo: typeof(MobileStatusMessagesDim).GetProperty("ActivityReasonId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileStatusMessagesDim).GetField("<ActivityReasonId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            activityReasonId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var descriptionAr = runtimeEntityType.AddProperty(
                "DescriptionAr",
                typeof(string),
                propertyInfo: typeof(MobileStatusMessagesDim).GetProperty("DescriptionAr", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileStatusMessagesDim).GetField("<DescriptionAr>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            descriptionAr.AddAnnotation("Relational:ColumnName", "DescriptionAR");
            descriptionAr.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var descriptionEn = runtimeEntityType.AddProperty(
                "DescriptionEn",
                typeof(string),
                propertyInfo: typeof(MobileStatusMessagesDim).GetProperty("DescriptionEn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileStatusMessagesDim).GetField("<DescriptionEn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            descriptionEn.AddAnnotation("Relational:ColumnName", "DescriptionEN");
            descriptionEn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isdeleted = runtimeEntityType.AddProperty(
                "Isdeleted",
                typeof(bool),
                propertyInfo: typeof(MobileStatusMessagesDim).GetProperty("Isdeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileStatusMessagesDim).GetField("<Isdeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isdeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var statusId = runtimeEntityType.AddProperty(
                "StatusId",
                typeof(int),
                propertyInfo: typeof(MobileStatusMessagesDim).GetProperty("StatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileStatusMessagesDim).GetField("<StatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            statusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { mobileStatusMessageId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK_MobileStatusMessages");

            var index = runtimeEntityType.AddIndex(
                new[] { activityReasonId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { statusId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ActivityReasonId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ActivityReasonId") }),
                principalEntityType);

            var activityReason = declaringEntityType.AddNavigation("ActivityReason",
                runtimeForeignKey,
                onDependent: true,
                typeof(ActivityReasonDim),
                propertyInfo: typeof(MobileStatusMessagesDim).GetProperty("ActivityReason", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileStatusMessagesDim).GetField("<ActivityReason>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var mobileStatusMessagesDims = principalEntityType.AddNavigation("MobileStatusMessagesDims",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<MobileStatusMessagesDim>),
                propertyInfo: typeof(ActivityReasonDim).GetProperty("MobileStatusMessagesDims", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ActivityReasonDim).GetField("<MobileStatusMessagesDims>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_MobileStatusMessagesDIM_ActivityReasonDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("StatusId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("MobileRequestStatusId") }),
                principalEntityType,
                required: true);

            var status = declaringEntityType.AddNavigation("Status",
                runtimeForeignKey,
                onDependent: true,
                typeof(MobileRequestStatusDim),
                propertyInfo: typeof(MobileStatusMessagesDim).GetProperty("Status", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileStatusMessagesDim).GetField("<Status>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var mobileStatusMessagesDims = principalEntityType.AddNavigation("MobileStatusMessagesDims",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<MobileStatusMessagesDim>),
                propertyInfo: typeof(MobileRequestStatusDim).GetProperty("MobileStatusMessagesDims", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(MobileRequestStatusDim).GetField("<MobileStatusMessagesDims>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_MobileStatusMessagesDIM_MobileRequestStatusDIM");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "MobileStatusMessagesDIM");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
