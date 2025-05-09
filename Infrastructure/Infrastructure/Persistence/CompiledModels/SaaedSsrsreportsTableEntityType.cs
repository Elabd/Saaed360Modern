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
    public partial class SaaedSsrsreportsTableEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.SaaedSsrsreportsTable",
                typeof(SaaedSsrsreportsTable),
                baseEntityType,
                propertyCount: 16,
                navigationCount: 1,
                foreignKeyCount: 1,
                unnamedIndexCount: 1,
                keyCount: 1);

            var pkid = runtimeEntityType.AddProperty(
                "Pkid",
                typeof(int),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("Pkid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<Pkid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            pkid.AddAnnotation("Relational:ColumnName", "PKID");
            pkid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var filterRelations = runtimeEntityType.AddProperty(
                "FilterRelations",
                typeof(string),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("FilterRelations", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<FilterRelations>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 500);
            filterRelations.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var fkReportTypeId = runtimeEntityType.AddProperty(
                "FkReportTypeId",
                typeof(int),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("FkReportTypeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<FkReportTypeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            fkReportTypeId.AddAnnotation("Relational:ColumnName", "Fk_ReportTypeId");
            fkReportTypeId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasAreaFilter = runtimeEntityType.AddProperty(
                "HasAreaFilter",
                typeof(bool),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("HasAreaFilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<HasAreaFilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            hasAreaFilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasCrfilter = runtimeEntityType.AddProperty(
                "HasCrfilter",
                typeof(bool),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("HasCrfilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<HasCrfilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            hasCrfilter.AddAnnotation("Relational:ColumnName", "HasCRFilter");
            hasCrfilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasDateRangeFilter = runtimeEntityType.AddProperty(
                "HasDateRangeFilter",
                typeof(bool),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("HasDateRangeFilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<HasDateRangeFilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            hasDateRangeFilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasEmirateFilter = runtimeEntityType.AddProperty(
                "HasEmirateFilter",
                typeof(bool),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("HasEmirateFilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<HasEmirateFilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            hasEmirateFilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasEmpFilter = runtimeEntityType.AddProperty(
                "HasEmpFilter",
                typeof(bool),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("HasEmpFilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<HasEmpFilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            hasEmpFilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasPatrolFilter = runtimeEntityType.AddProperty(
                "HasPatrolFilter",
                typeof(bool?),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("HasPatrolFilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<HasPatrolFilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            hasPatrolFilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasTimeRangeFilter = runtimeEntityType.AddProperty(
                "HasTimeRangeFilter",
                typeof(bool),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("HasTimeRangeFilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<HasTimeRangeFilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            hasTimeRangeFilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool?),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var paramsNumber = runtimeEntityType.AddProperty(
                "ParamsNumber",
                typeof(int?),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("ParamsNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<ParamsNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            paramsNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportDescription = runtimeEntityType.AddProperty(
                "ReportDescription",
                typeof(string),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("ReportDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<ReportDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 500);
            reportDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportName = runtimeEntityType.AddProperty(
                "ReportName",
                typeof(string),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("ReportName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<ReportName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 200);
            reportName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportPath = runtimeEntityType.AddProperty(
                "ReportPath",
                typeof(string),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("ReportPath", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<ReportPath>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 500);
            reportPath.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var roles = runtimeEntityType.AddProperty(
                "Roles",
                typeof(string),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("Roles", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<Roles>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 500);
            roles.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { pkid });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { fkReportTypeId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("FkReportTypeId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Pkid") }),
                principalEntityType,
                required: true);

            var fkReportType = declaringEntityType.AddNavigation("FkReportType",
                runtimeForeignKey,
                onDependent: true,
                typeof(SaaedSsrsreportsType),
                propertyInfo: typeof(SaaedSsrsreportsTable).GetProperty("FkReportType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsTable).GetField("<FkReportType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var saaedSsrsreportsTables = principalEntityType.AddNavigation("SaaedSsrsreportsTables",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<SaaedSsrsreportsTable>),
                propertyInfo: typeof(SaaedSsrsreportsType).GetProperty("SaaedSsrsreportsTables", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SaaedSsrsreportsType).GetField("<SaaedSsrsreportsTables>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_SaaedSSRSReportsTable_SaaedSSRSReportsType");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "SaaedSSRSReportsTable");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
