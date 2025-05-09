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
    public partial class ViewMissionDetailEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.ViewMissionDetail",
                typeof(ViewMissionDetail),
                baseEntityType,
                propertyCount: 13);

            var acceptId = runtimeEntityType.AddProperty(
                "AcceptId",
                typeof(long),
                propertyInfo: typeof(ViewMissionDetail).GetProperty("AcceptId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMissionDetail).GetField("<AcceptId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            acceptId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var activityDate = runtimeEntityType.AddProperty(
                "ActivityDate",
                typeof(DateTime?),
                propertyInfo: typeof(ViewMissionDetail).GetProperty("ActivityDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMissionDetail).GetField("<ActivityDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            activityDate.AddAnnotation("Relational:ColumnType", "datetime");
            activityDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var areaId = runtimeEntityType.AddProperty(
                "AreaId",
                typeof(long),
                propertyInfo: typeof(ViewMissionDetail).GetProperty("AreaId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMissionDetail).GetField("<AreaId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            areaId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var comment = runtimeEntityType.AddProperty(
                "Comment",
                typeof(string),
                propertyInfo: typeof(ViewMissionDetail).GetProperty("Comment", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMissionDetail).GetField("<Comment>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            comment.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var endDate = runtimeEntityType.AddProperty(
                "EndDate",
                typeof(DateTime?),
                propertyInfo: typeof(ViewMissionDetail).GetProperty("EndDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMissionDetail).GetField("<EndDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            endDate.AddAnnotation("Relational:ColumnType", "datetime");
            endDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemId = runtimeEntityType.AddProperty(
                "ItemId",
                typeof(long),
                propertyInfo: typeof(ViewMissionDetail).GetProperty("ItemId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMissionDetail).GetField("<ItemId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            itemId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var missionCode = runtimeEntityType.AddProperty(
                "MissionCode",
                typeof(string),
                propertyInfo: typeof(ViewMissionDetail).GetProperty("MissionCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMissionDetail).GetField("<MissionCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 20);
            missionCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var missionType = runtimeEntityType.AddProperty(
                "MissionType",
                typeof(string),
                propertyInfo: typeof(ViewMissionDetail).GetProperty("MissionType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMissionDetail).GetField("<MissionType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            missionType.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var missionTypeId = runtimeEntityType.AddProperty(
                "MissionTypeId",
                typeof(int),
                propertyInfo: typeof(ViewMissionDetail).GetProperty("MissionTypeId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMissionDetail).GetField("<MissionTypeId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            missionTypeId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var patrolCode = runtimeEntityType.AddProperty(
                "PatrolCode",
                typeof(string),
                propertyInfo: typeof(ViewMissionDetail).GetProperty("PatrolCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMissionDetail).GetField("<PatrolCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            patrolCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var requestId = runtimeEntityType.AddProperty(
                "RequestId",
                typeof(long),
                propertyInfo: typeof(ViewMissionDetail).GetProperty("RequestId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMissionDetail).GetField("<RequestId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            requestId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var startDate = runtimeEntityType.AddProperty(
                "StartDate",
                typeof(DateTime?),
                propertyInfo: typeof(ViewMissionDetail).GetProperty("StartDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMissionDetail).GetField("<StartDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            startDate.AddAnnotation("Relational:ColumnType", "datetime");
            startDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var statusId = runtimeEntityType.AddProperty(
                "StatusId",
                typeof(int),
                propertyInfo: typeof(ViewMissionDetail).GetProperty("StatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMissionDetail).GetField("<StatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
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
            runtimeEntityType.AddAnnotation("Relational:ViewName", "ViewMissionDetail");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
