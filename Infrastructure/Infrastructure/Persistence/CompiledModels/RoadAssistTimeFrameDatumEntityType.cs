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
    public partial class RoadAssistTimeFrameDatumEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.RoadAssistTimeFrameDatum",
                typeof(RoadAssistTimeFrameDatum),
                baseEntityType,
                propertyCount: 9,
                keyCount: 1);

            var timeFrameId = runtimeEntityType.AddProperty(
                "TimeFrameId",
                typeof(Guid),
                propertyInfo: typeof(RoadAssistTimeFrameDatum).GetProperty("TimeFrameId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistTimeFrameDatum).GetField("<TimeFrameId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            timeFrameId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var dayNameAr = runtimeEntityType.AddProperty(
                "DayNameAr",
                typeof(string),
                propertyInfo: typeof(RoadAssistTimeFrameDatum).GetProperty("DayNameAr", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistTimeFrameDatum).GetField("<DayNameAr>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            dayNameAr.AddAnnotation("Relational:ColumnName", "DayNameAR");
            dayNameAr.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var dayNameEn = runtimeEntityType.AddProperty(
                "DayNameEn",
                typeof(string),
                propertyInfo: typeof(RoadAssistTimeFrameDatum).GetProperty("DayNameEn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistTimeFrameDatum).GetField("<DayNameEn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            dayNameEn.AddAnnotation("Relational:ColumnName", "DayNameEN");
            dayNameEn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var dayNumber = runtimeEntityType.AddProperty(
                "DayNumber",
                typeof(int?),
                propertyInfo: typeof(RoadAssistTimeFrameDatum).GetProperty("DayNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistTimeFrameDatum).GetField("<DayNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            dayNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var monthNameAr = runtimeEntityType.AddProperty(
                "MonthNameAr",
                typeof(string),
                propertyInfo: typeof(RoadAssistTimeFrameDatum).GetProperty("MonthNameAr", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistTimeFrameDatum).GetField("<MonthNameAr>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            monthNameAr.AddAnnotation("Relational:ColumnName", "MonthNameAR");
            monthNameAr.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var monthNameEn = runtimeEntityType.AddProperty(
                "MonthNameEn",
                typeof(string),
                propertyInfo: typeof(RoadAssistTimeFrameDatum).GetProperty("MonthNameEn", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistTimeFrameDatum).GetField("<MonthNameEn>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            monthNameEn.AddAnnotation("Relational:ColumnName", "MonthNameEN");
            monthNameEn.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var monthNumber = runtimeEntityType.AddProperty(
                "MonthNumber",
                typeof(int?),
                propertyInfo: typeof(RoadAssistTimeFrameDatum).GetProperty("MonthNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistTimeFrameDatum).GetField("<MonthNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            monthNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var quarterNumber = runtimeEntityType.AddProperty(
                "QuarterNumber",
                typeof(int?),
                propertyInfo: typeof(RoadAssistTimeFrameDatum).GetProperty("QuarterNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistTimeFrameDatum).GetField("<QuarterNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            quarterNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var weekNumber = runtimeEntityType.AddProperty(
                "WeekNumber",
                typeof(int?),
                propertyInfo: typeof(RoadAssistTimeFrameDatum).GetProperty("WeekNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RoadAssistTimeFrameDatum).GetField("<WeekNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            weekNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { timeFrameId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__RoadAssi__F918F41B6B5C1EC2");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "RoadAssistTimeFrameData");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
