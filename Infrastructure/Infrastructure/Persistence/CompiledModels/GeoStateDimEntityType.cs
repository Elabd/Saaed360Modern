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
    public partial class GeoStateDimEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.GeoStateDim",
                typeof(GeoStateDim),
                baseEntityType,
                propertyCount: 8,
                navigationCount: 1,
                foreignKeyCount: 1,
                unnamedIndexCount: 1,
                keyCount: 1);

            var geoStateId = runtimeEntityType.AddProperty(
                "GeoStateId",
                typeof(int),
                propertyInfo: typeof(GeoStateDim).GetProperty("GeoStateId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GeoStateDim).GetField("<GeoStateId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            geoStateId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var code = runtimeEntityType.AddProperty(
                "Code",
                typeof(string),
                propertyInfo: typeof(GeoStateDim).GetProperty("Code", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GeoStateDim).GetField("<Code>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50);
            code.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createDateTimeStamp = runtimeEntityType.AddProperty(
                "CreateDateTimeStamp",
                typeof(DateTime?),
                propertyInfo: typeof(GeoStateDim).GetProperty("CreateDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GeoStateDim).GetField("<CreateDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            createDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            createDateTimeStamp.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            createDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool?),
                propertyInfo: typeof(GeoStateDim).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GeoStateDim).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            isDeleted.AddAnnotation("Relational:DefaultValue", false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedDateTimeStamp = runtimeEntityType.AddProperty(
                "ModifiedDateTimeStamp",
                typeof(DateTime?),
                propertyInfo: typeof(GeoStateDim).GetProperty("ModifiedDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GeoStateDim).GetField("<ModifiedDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            modifiedDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            modifiedDateTimeStamp.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            modifiedDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusId = runtimeEntityType.AddProperty(
                "RowStatusId",
                typeof(int?),
                propertyInfo: typeof(GeoStateDim).GetProperty("RowStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GeoStateDim).GetField("<RowStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            rowStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var stateCode = runtimeEntityType.AddProperty(
                "StateCode",
                typeof(string),
                propertyInfo: typeof(GeoStateDim).GetProperty("StateCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GeoStateDim).GetField("<StateCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 5);
            stateCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var stateName = runtimeEntityType.AddProperty(
                "StateName",
                typeof(string),
                propertyInfo: typeof(GeoStateDim).GetProperty("StateName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GeoStateDim).GetField("<StateName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            stateName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { geoStateId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { rowStatusId });

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
                propertyInfo: typeof(GeoStateDim).GetProperty("RowStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(GeoStateDim).GetField("<RowStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var geoStateDims = principalEntityType.AddNavigation("GeoStateDims",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<GeoStateDim>),
                propertyInfo: typeof(RowStatusDim).GetProperty("GeoStateDims", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RowStatusDim).GetField("<GeoStateDims>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_GeoStateDIM_RowStatusDIM");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "GeoStateDIM");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
