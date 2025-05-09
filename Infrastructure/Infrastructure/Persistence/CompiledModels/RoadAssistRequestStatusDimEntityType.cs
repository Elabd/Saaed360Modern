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
    public partial class RoadAssistRequestStatusDimEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.RoadAssistRequestStatusDim",
                typeof(RoadAssistRequestStatusDim),
                baseEntityType,
                propertyCount: 13,
                navigationCount: 7,
                foreignKeyCount: 2,
                unnamedIndexCount: 2,
                keyCount: 1);

            var requestStatusId = runtimeEntityType.AddProperty(
                "RequestStatusId",
                typeof(Guid),
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("RequestStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<RequestStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            requestStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var actionRequestStatusNameAr = runtimeEntityType.AddProperty(
                "ActionRequestStatusNameAr",
                typeof(string),
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("ActionRequestStatusNameAr", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<ActionRequestStatusNameAr>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            actionRequestStatusNameAr.AddAnnotation("Relational:ColumnName", "ActionRequestStatusNameAR");
            actionRequestStatusNameAr.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var actionRequestStatusNameEn = runtimeEntityType.AddProperty(
                "ActionRequestStatusNameEn",
                typeof(string),
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("ActionRequestStatusNameEn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<ActionRequestStatusNameEn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            actionRequestStatusNameEn.AddAnnotation("Relational:ColumnName", "ActionRequestStatusNameEN");
            actionRequestStatusNameEn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var code = runtimeEntityType.AddProperty(
                "Code",
                typeof(string),
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("Code", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<Code>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50,
                unicode: false);
            code.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createdByUserId = runtimeEntityType.AddProperty(
                "CreatedByUserId",
                typeof(Guid),
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("CreatedByUserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<CreatedByUserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            createdByUserId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var creationDate = runtimeEntityType.AddProperty(
                "CreationDate",
                typeof(DateTime),
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("CreationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<CreationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            creationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isClosed = runtimeEntityType.AddProperty(
                "IsClosed",
                typeof(bool),
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("IsClosed", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<IsClosed>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isClosed.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool),
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastModificationDate = runtimeEntityType.AddProperty(
                "LastModificationDate",
                typeof(DateTime?),
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("LastModificationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<LastModificationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastModificationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var lastModifiedByUserId = runtimeEntityType.AddProperty(
                "LastModifiedByUserId",
                typeof(Guid?),
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("LastModifiedByUserId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<LastModifiedByUserId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            lastModifiedByUserId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var requestStatusColor = runtimeEntityType.AddProperty(
                "RequestStatusColor",
                typeof(string),
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("RequestStatusColor", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<RequestStatusColor>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            requestStatusColor.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var requestStatusNameAr = runtimeEntityType.AddProperty(
                "RequestStatusNameAr",
                typeof(string),
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("RequestStatusNameAr", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<RequestStatusNameAr>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 100);
            requestStatusNameAr.AddAnnotation("Relational:ColumnName", "RequestStatusNameAR");
            requestStatusNameAr.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var requestStatusNameEn = runtimeEntityType.AddProperty(
                "RequestStatusNameEn",
                typeof(string),
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("RequestStatusNameEn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<RequestStatusNameEn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 100,
                unicode: false);
            requestStatusNameEn.AddAnnotation("Relational:ColumnName", "RequestStatusNameEN");
            requestStatusNameEn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { requestStatusId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__RoadAssi__7094B79BD8E9FB4C");

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
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("CreatedByUser", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<CreatedByUser>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var roadAssistRequestStatusDimCreatedByUsers = principalEntityType.AddNavigation("RoadAssistRequestStatusDimCreatedByUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RoadAssistRequestStatusDim>),
                propertyInfo: typeof(RoadAssistUser).GetProperty("RoadAssistRequestStatusDimCreatedByUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUser).GetField("<RoadAssistRequestStatusDimCreatedByUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RoadAssis__Creat__1C395C40");
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
                propertyInfo: typeof(RoadAssistRequestStatusDim).GetProperty("LastModifiedByUser", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistRequestStatusDim).GetField("<LastModifiedByUser>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var roadAssistRequestStatusDimLastModifiedByUsers = principalEntityType.AddNavigation("RoadAssistRequestStatusDimLastModifiedByUsers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RoadAssistRequestStatusDim>),
                propertyInfo: typeof(RoadAssistUser).GetProperty("RoadAssistRequestStatusDimLastModifiedByUsers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistUser).GetField("<RoadAssistRequestStatusDimLastModifiedByUsers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__RoadAssis__LastM__1D2D8079");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "RoadAssistRequestStatusDIM");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
