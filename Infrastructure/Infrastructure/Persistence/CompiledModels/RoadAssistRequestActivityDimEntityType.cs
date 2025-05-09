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
    public partial class RoadAssistRequestActivityDimEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.RoadAssistRequestActivityDim",
                typeof(RoadAssistRequestActivityDim),
                baseEntityType,
                propertyCount: 10,
                navigationCount: 3,
                foreignKeyCount: 2,
                unnamedIndexCount: 2,
                keyCount: 1);

            var requestActivityId = runtimeEntityType.AddProperty(
                "RequestActivityId",
                typeof(Guid),
                propertyInfo: typeof(RoadAssistRequestActivityDim).GetProperty("RequestActivityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestActivityDim).GetField("<RequestActivityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            requestActivityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var activityOrder = runtimeEntityType.AddProperty(
                "ActivityOrder",
                typeof(int),
                propertyInfo: typeof(RoadAssistRequestActivityDim).GetProperty("ActivityOrder", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestActivityDim).GetField("<ActivityOrder>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            activityOrder.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var code = runtimeEntityType.AddProperty(
                "Code",
                typeof(string),
                propertyInfo: typeof(RoadAssistRequestActivityDim).GetProperty("Code", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestActivityDim).GetField("<Code>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50,
                unicode: false);
            code.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createdByUserId = runtimeEntityType.AddProperty(
                "CreatedByUserId",
                typeof(Guid),
                propertyInfo: typeof(RoadAssistRequestActivityDim).GetProperty("CreatedByUserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestActivityDim).GetField("<CreatedByUserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            createdByUserId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime),
                propertyInfo: typeof(RoadAssistRequestActivityDim).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestActivityDim).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            creationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool),
                propertyInfo: typeof(RoadAssistRequestActivityDim).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestActivityDim).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastModificationDate = runtimeEntityType.AddProperty(
                "LastModificationDate",
                typeof(DateTime?),
                propertyInfo: typeof(RoadAssistRequestActivityDim).GetProperty("LastModificationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestActivityDim).GetField("<LastModificationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastModificationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastModifiedByUserId = runtimeEntityType.AddProperty(
                "LastModifiedByUserId",
                typeof(Guid?),
                propertyInfo: typeof(RoadAssistRequestActivityDim).GetProperty("LastModifiedByUserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestActivityDim).GetField("<LastModifiedByUserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastModifiedByUserId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var requestActivityNameAr = runtimeEntityType.AddProperty(
                "RequestActivityNameAr",
                typeof(string),
                propertyInfo: typeof(RoadAssistRequestActivityDim).GetProperty("RequestActivityNameAr", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestActivityDim).GetField("<RequestActivityNameAr>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 100);
            requestActivityNameAr.AddAnnotation("Relational:ColumnName", "RequestActivityNameAR");
            requestActivityNameAr.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var requestActivityNameEn = runtimeEntityType.AddProperty(
                "RequestActivityNameEn",
                typeof(string),
                propertyInfo: typeof(RoadAssistRequestActivityDim).GetProperty("RequestActivityNameEn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestActivityDim).GetField("<RequestActivityNameEn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 100,
                unicode: false);
            requestActivityNameEn.AddAnnotation("Relational:ColumnName", "RequestActivityNameEN");
            requestActivityNameEn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { requestActivityId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__RoadAssi__21B89D16BBBFA72A");

            var index = runtimeEntityType.AddIndex(
                new[] { createdByUserId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { lastModifiedByUserId });

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
                propertyInfo: typeof(RoadAssistRequestActivityDim).GetProperty("CreatedByUser", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestActivityDim).GetField("<CreatedByUser>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var roadAssistRequestActivityDimCreatedByUsers = principalEntityType.AddNavigation("RoadAssistRequestActivityDimCreatedByUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RoadAssistRequestActivityDim>),
                propertyInfo: typeof(RoadAssistUser).GetProperty("RoadAssistRequestActivityDimCreatedByUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUser).GetField("<RoadAssistRequestActivityDimCreatedByUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RoadAssis__Creat__0CF718B0");
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
                propertyInfo: typeof(RoadAssistRequestActivityDim).GetProperty("LastModifiedByUser", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestActivityDim).GetField("<LastModifiedByUser>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var roadAssistRequestActivityDimLastModifiedByUsers = principalEntityType.AddNavigation("RoadAssistRequestActivityDimLastModifiedByUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RoadAssistRequestActivityDim>),
                propertyInfo: typeof(RoadAssistUser).GetProperty("RoadAssistRequestActivityDimLastModifiedByUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUser).GetField("<RoadAssistRequestActivityDimLastModifiedByUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RoadAssis__LastM__0DEB3CE9");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "RoadAssistRequestActivityDIM");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
