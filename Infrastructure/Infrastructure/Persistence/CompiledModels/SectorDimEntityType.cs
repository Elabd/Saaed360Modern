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
    public partial class SectorDimEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.SectorDim",
                typeof(SectorDim),
                baseEntityType,
                propertyCount: 4,
                navigationCount: 3,
                foreignKeyCount: 1,
                unnamedIndexCount: 1,
                keyCount: 1);

            var sectorId = runtimeEntityType.AddProperty(
                "SectorId",
                typeof(long),
                propertyInfo: typeof(SectorDim).GetProperty("SectorId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SectorDim).GetField("<SectorId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            sectorId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportAreaId = runtimeEntityType.AddProperty(
                "ReportAreaId",
                typeof(long),
                propertyInfo: typeof(SectorDim).GetProperty("ReportAreaId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SectorDim).GetField("<ReportAreaId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            reportAreaId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sectorCode = runtimeEntityType.AddProperty(
                "SectorCode",
                typeof(string),
                propertyInfo: typeof(SectorDim).GetProperty("SectorCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SectorDim).GetField("<SectorCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            sectorCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sectorName = runtimeEntityType.AddProperty(
                "SectorName",
                typeof(string),
                propertyInfo: typeof(SectorDim).GetProperty("SectorName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SectorDim).GetField("<SectorName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 200);
            sectorName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { sectorId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { reportAreaId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ReportAreaId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AreaId") }),
                principalEntityType,
                required: true);

            var reportArea = declaringEntityType.AddNavigation("ReportArea",
                runtimeForeignKey,
                onDependent: true,
                typeof(ReportAreaDim),
                propertyInfo: typeof(SectorDim).GetProperty("ReportArea", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SectorDim).GetField("<ReportArea>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var sectorDims = principalEntityType.AddNavigation("SectorDims",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<SectorDim>),
                propertyInfo: typeof(ReportAreaDim).GetProperty("SectorDims", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ReportAreaDim).GetField("<SectorDims>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_SectorDIM_ReportAreaDIM");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "SectorDIM");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
