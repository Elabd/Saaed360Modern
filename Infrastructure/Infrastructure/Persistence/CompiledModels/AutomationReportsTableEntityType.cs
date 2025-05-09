﻿// <auto-generated />
using System;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Infrastructure.Persistence.CompiledModels
{
    [EntityFrameworkInternal]
    public partial class AutomationReportsTableEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.AutomationReportsTable",
                typeof(AutomationReportsTable),
                baseEntityType,
                propertyCount: 15,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(int),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var emirateSource = runtimeEntityType.AddProperty(
                "EmirateSource",
                typeof(int?),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("EmirateSource", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<EmirateSource>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            emirateSource.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var filterRelations = runtimeEntityType.AddProperty(
                "FilterRelations",
                typeof(string),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("FilterRelations", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<FilterRelations>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 500);
            filterRelations.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasAreaFilter = runtimeEntityType.AddProperty(
                "HasAreaFilter",
                typeof(bool),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("HasAreaFilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<HasAreaFilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            hasAreaFilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasCrfilter = runtimeEntityType.AddProperty(
                "HasCrfilter",
                typeof(bool),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("HasCrfilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<HasCrfilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            hasCrfilter.AddAnnotation("Relational:ColumnName", "HasCRFilter");
            hasCrfilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasDateRangeFilter = runtimeEntityType.AddProperty(
                "HasDateRangeFilter",
                typeof(bool),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("HasDateRangeFilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<HasDateRangeFilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            hasDateRangeFilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasEmirateFilter = runtimeEntityType.AddProperty(
                "HasEmirateFilter",
                typeof(bool),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("HasEmirateFilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<HasEmirateFilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            hasEmirateFilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasEmpFilter = runtimeEntityType.AddProperty(
                "HasEmpFilter",
                typeof(bool),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("HasEmpFilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<HasEmpFilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            hasEmpFilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasPatrolFilter = runtimeEntityType.AddProperty(
                "HasPatrolFilter",
                typeof(bool),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("HasPatrolFilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<HasPatrolFilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            hasPatrolFilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var hasTimeRangeFilter = runtimeEntityType.AddProperty(
                "HasTimeRangeFilter",
                typeof(bool),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("HasTimeRangeFilter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<HasTimeRangeFilter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            hasTimeRangeFilter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var paramsNumber = runtimeEntityType.AddProperty(
                "ParamsNumber",
                typeof(int?),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("ParamsNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<ParamsNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            paramsNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportDescription = runtimeEntityType.AddProperty(
                "ReportDescription",
                typeof(string),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("ReportDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<ReportDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 500);
            reportDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportName = runtimeEntityType.AddProperty(
                "ReportName",
                typeof(string),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("ReportName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<ReportName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 200);
            reportName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportTypeId = runtimeEntityType.AddProperty(
                "ReportTypeId",
                typeof(int),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("ReportTypeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<ReportTypeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            reportTypeId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var roles = runtimeEntityType.AddProperty(
                "Roles",
                typeof(string),
                propertyInfo: typeof(AutomationReportsTable).GetProperty("Roles", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AutomationReportsTable).GetField("<Roles>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 500);
            roles.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "AutomationReportsTable");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
