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
    public partial class VMobileRequestListEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.VMobileRequestList",
                typeof(VMobileRequestList),
                baseEntityType,
                propertyCount: 23);

            var area = runtimeEntityType.AddProperty(
                "Area",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("Area", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<Area>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            area.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var areaId = runtimeEntityType.AddProperty(
                "AreaId",
                typeof(long),
                propertyInfo: typeof(VMobileRequestList).GetProperty("AreaId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<AreaId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            areaId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var date = runtimeEntityType.AddProperty(
                "Date",
                typeof(DateTime),
                propertyInfo: typeof(VMobileRequestList).GetProperty("Date", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<Date>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            date.AddAnnotation("Relational:ColumnType", "datetime");
            date.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emirateAr = runtimeEntityType.AddProperty(
                "EmirateAr",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("EmirateAr", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<EmirateAr>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            emirateAr.AddAnnotation("Relational:ColumnName", "EmirateAR");
            emirateAr.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emirateEn = runtimeEntityType.AddProperty(
                "EmirateEn",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("EmirateEn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<EmirateEn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            emirateEn.AddAnnotation("Relational:ColumnName", "EmirateEN");
            emirateEn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emirateId = runtimeEntityType.AddProperty(
                "EmirateId",
                typeof(long?),
                propertyInfo: typeof(VMobileRequestList).GetProperty("EmirateId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<EmirateId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            emirateId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(long),
                propertyInfo: typeof(VMobileRequestList).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDisplayedInRequestsList = runtimeEntityType.AddProperty(
                "IsDisplayedInRequestsList",
                typeof(int),
                propertyInfo: typeof(VMobileRequestList).GetProperty("IsDisplayedInRequestsList", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<IsDisplayedInRequestsList>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            isDisplayedInRequestsList.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var phoneNumber = runtimeEntityType.AddProperty(
                "PhoneNumber",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("PhoneNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<PhoneNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            phoneNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var planningStatusAr = runtimeEntityType.AddProperty(
                "PlanningStatusAr",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("PlanningStatusAr", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<PlanningStatusAr>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            planningStatusAr.AddAnnotation("Relational:ColumnName", "PlanningStatusAR");
            planningStatusAr.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var planningStatusCode = runtimeEntityType.AddProperty(
                "PlanningStatusCode",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("PlanningStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<PlanningStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            planningStatusCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var planningStatusDisplayAr = runtimeEntityType.AddProperty(
                "PlanningStatusDisplayAr",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("PlanningStatusDisplayAr", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<PlanningStatusDisplayAr>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            planningStatusDisplayAr.AddAnnotation("Relational:ColumnName", "PlanningStatusDisplayAR");
            planningStatusDisplayAr.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var planningStatusDisplayEn = runtimeEntityType.AddProperty(
                "PlanningStatusDisplayEn",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("PlanningStatusDisplayEn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<PlanningStatusDisplayEn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            planningStatusDisplayEn.AddAnnotation("Relational:ColumnName", "PlanningStatusDisplayEN");
            planningStatusDisplayEn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var planningStatusEn = runtimeEntityType.AddProperty(
                "PlanningStatusEn",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("PlanningStatusEn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<PlanningStatusEn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            planningStatusEn.AddAnnotation("Relational:ColumnName", "PlanningStatusEN");
            planningStatusEn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var planningStatusId = runtimeEntityType.AddProperty(
                "PlanningStatusId",
                typeof(int?),
                propertyInfo: typeof(VMobileRequestList).GetProperty("PlanningStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<PlanningStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            planningStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportDate = runtimeEntityType.AddProperty(
                "ReportDate",
                typeof(DateTime),
                propertyInfo: typeof(VMobileRequestList).GetProperty("ReportDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<ReportDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            reportDate.AddAnnotation("Relational:ColumnType", "datetime");
            reportDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportNumber = runtimeEntityType.AddProperty(
                "ReportNumber",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("ReportNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<ReportNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            reportNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportStatusAr = runtimeEntityType.AddProperty(
                "ReportStatusAr",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("ReportStatusAr", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<ReportStatusAr>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            reportStatusAr.AddAnnotation("Relational:ColumnName", "ReportStatusAR");
            reportStatusAr.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportStatusCode = runtimeEntityType.AddProperty(
                "ReportStatusCode",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("ReportStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<ReportStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 20);
            reportStatusCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportStatusId = runtimeEntityType.AddProperty(
                "ReportStatusId",
                typeof(int?),
                propertyInfo: typeof(VMobileRequestList).GetProperty("ReportStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<ReportStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            reportStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var statusAr = runtimeEntityType.AddProperty(
                "StatusAr",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("StatusAr", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<StatusAr>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            statusAr.AddAnnotation("Relational:ColumnName", "StatusAR");
            statusAr.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var statusEn = runtimeEntityType.AddProperty(
                "StatusEn",
                typeof(string),
                propertyInfo: typeof(VMobileRequestList).GetProperty("StatusEn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<StatusEn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            statusEn.AddAnnotation("Relational:ColumnName", "StatusEN");
            statusEn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var statusId = runtimeEntityType.AddProperty(
                "StatusId",
                typeof(int),
                propertyInfo: typeof(VMobileRequestList).GetProperty("StatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(VMobileRequestList).GetField("<StatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            statusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "v_MobileRequestList");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
