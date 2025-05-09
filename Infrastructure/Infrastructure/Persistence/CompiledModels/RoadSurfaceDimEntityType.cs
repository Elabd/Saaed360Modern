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
    public partial class RoadSurfaceDimEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.RoadSurfaceDim",
                typeof(RoadSurfaceDim),
                baseEntityType,
                propertyCount: 7,
                navigationCount: 2,
                foreignKeyCount: 1,
                unnamedIndexCount: 1,
                namedIndexCount: 1,
                keyCount: 1);

            var roadSurfaceId = runtimeEntityType.AddProperty(
                "RoadSurfaceId",
                typeof(int),
                propertyInfo: typeof(RoadSurfaceDim).GetProperty("RoadSurfaceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadSurfaceDim).GetField("<RoadSurfaceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            roadSurfaceId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(RoadSurfaceDim).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadSurfaceDim).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            description.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDefaultForReportConstruction = runtimeEntityType.AddProperty(
                "IsDefaultForReportConstruction",
                typeof(bool),
                propertyInfo: typeof(RoadSurfaceDim).GetProperty("IsDefaultForReportConstruction", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadSurfaceDim).GetField("<IsDefaultForReportConstruction>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            isDefaultForReportConstruction.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool?),
                propertyInfo: typeof(RoadSurfaceDim).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadSurfaceDim).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            isDeleted.AddAnnotation("Relational:DefaultValue", false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusId = runtimeEntityType.AddProperty(
                "RowStatusId",
                typeof(int?),
                propertyInfo: typeof(RoadSurfaceDim).GetProperty("RowStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadSurfaceDim).GetField("<RowStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            rowStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var timeStamp = runtimeEntityType.AddProperty(
                "TimeStamp",
                typeof(byte[]),
                propertyInfo: typeof(RoadSurfaceDim).GetProperty("TimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadSurfaceDim).GetField("<TimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                concurrencyToken: true,
                valueGenerated: ValueGenerated.OnAddOrUpdate,
                beforeSaveBehavior: PropertySaveBehavior.Ignore,
                afterSaveBehavior: PropertySaveBehavior.Ignore);
            timeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var versionDateTime = runtimeEntityType.AddProperty(
                "VersionDateTime",
                typeof(DateTime),
                propertyInfo: typeof(RoadSurfaceDim).GetProperty("VersionDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadSurfaceDim).GetField("<VersionDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            versionDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            versionDateTime.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            versionDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { roadSurfaceId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__RoadSurf__E5E0D7BEC4873217");

            var index = runtimeEntityType.AddIndex(
                new[] { rowStatusId });

            var uNQ_RoadSurfaceDIM_IsDefaultForReportConstruction = runtimeEntityType.AddIndex(
                new[] { isDefaultForReportConstruction },
                name: "UNQ_RoadSurfaceDIM_IsDefaultForReportConstruction",
                unique: true);
            uNQ_RoadSurfaceDIM_IsDefaultForReportConstruction.AddAnnotation("Relational:Filter", "([IsDefaultForReportConstruction]=(1))");

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("RowStatusId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("RowStatusId") }),
                principalEntityType);

            var rowStatus = declaringEntityType.AddNavigation("RowStatus",
                runtimeForeignKey,
                onDependent: true,
                typeof(RowStatusDim),
                propertyInfo: typeof(RoadSurfaceDim).GetProperty("RowStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadSurfaceDim).GetField("<RowStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var roadSurfaceDims = principalEntityType.AddNavigation("RoadSurfaceDims",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<RoadSurfaceDim>),
                propertyInfo: typeof(RowStatusDim).GetProperty("RoadSurfaceDims", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RowStatusDim).GetField("<RoadSurfaceDims>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_RoadSurfaceDIM_RowStatusDIM");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "RoadSurfaceDIM");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
