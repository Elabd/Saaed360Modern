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
    public partial class IcccviewIncidentChildDelayStatusEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.IcccviewIncidentChildDelayStatus",
                typeof(IcccviewIncidentChildDelayStatus),
                baseEntityType,
                propertyCount: 7);

            var activityCreatedDate = runtimeEntityType.AddProperty(
                "ActivityCreatedDate",
                typeof(DateTime?),
                propertyInfo: typeof(IcccviewIncidentChildDelayStatus).GetProperty("ActivityCreatedDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccviewIncidentChildDelayStatus).GetField("<ActivityCreatedDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            activityCreatedDate.AddAnnotation("Relational:ColumnType", "datetime");
            activityCreatedDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var childWorkFlowId = runtimeEntityType.AddProperty(
                "ChildWorkFlowId",
                typeof(Guid?),
                propertyInfo: typeof(IcccviewIncidentChildDelayStatus).GetProperty("ChildWorkFlowId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccviewIncidentChildDelayStatus).GetField("<ChildWorkFlowId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            childWorkFlowId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var description = runtimeEntityType.AddProperty(
                "Description",
                typeof(string),
                propertyInfo: typeof(IcccviewIncidentChildDelayStatus).GetProperty("Description", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccviewIncidentChildDelayStatus).GetField("<Description>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            description.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentId = runtimeEntityType.AddProperty(
                "IncidentId",
                typeof(long),
                propertyInfo: typeof(IcccviewIncidentChildDelayStatus).GetProperty("IncidentId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccviewIncidentChildDelayStatus).GetField("<IncidentId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            incidentId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var patrolAssignmentId = runtimeEntityType.AddProperty(
                "PatrolAssignmentId",
                typeof(long),
                propertyInfo: typeof(IcccviewIncidentChildDelayStatus).GetProperty("PatrolAssignmentId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccviewIncidentChildDelayStatus).GetField("<PatrolAssignmentId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            patrolAssignmentId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var patrolDelayStatus = runtimeEntityType.AddProperty(
                "PatrolDelayStatus",
                typeof(string),
                propertyInfo: typeof(IcccviewIncidentChildDelayStatus).GetProperty("PatrolDelayStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccviewIncidentChildDelayStatus).GetField("<PatrolDelayStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            patrolDelayStatus.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var patrolType = runtimeEntityType.AddProperty(
                "PatrolType",
                typeof(string),
                propertyInfo: typeof(IcccviewIncidentChildDelayStatus).GetProperty("PatrolType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(IcccviewIncidentChildDelayStatus).GetField("<PatrolType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 20);
            patrolType.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "ICCCViewIncidentChildDelayStatus");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
