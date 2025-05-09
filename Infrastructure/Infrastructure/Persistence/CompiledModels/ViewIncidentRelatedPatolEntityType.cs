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
    public partial class ViewIncidentRelatedPatolEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.ViewIncidentRelatedPatol",
                typeof(ViewIncidentRelatedPatol),
                baseEntityType,
                propertyCount: 8);

            var activityItemId = runtimeEntityType.AddProperty(
                "ActivityItemId",
                typeof(long),
                propertyInfo: typeof(ViewIncidentRelatedPatol).GetProperty("ActivityItemId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIncidentRelatedPatol).GetField("<ActivityItemId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            activityItemId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var activityItemWf = runtimeEntityType.AddProperty(
                "ActivityItemWf",
                typeof(Guid?),
                propertyInfo: typeof(ViewIncidentRelatedPatol).GetProperty("ActivityItemWf", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIncidentRelatedPatol).GetField("<ActivityItemWf>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            activityItemWf.AddAnnotation("Relational:ColumnName", "ActivityItemWF");
            activityItemWf.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var currentStatusId = runtimeEntityType.AddProperty(
                "CurrentStatusId",
                typeof(long?),
                propertyInfo: typeof(ViewIncidentRelatedPatol).GetProperty("CurrentStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIncidentRelatedPatol).GetField("<CurrentStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            currentStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var dispatchActivityId = runtimeEntityType.AddProperty(
                "DispatchActivityId",
                typeof(long),
                propertyInfo: typeof(ViewIncidentRelatedPatol).GetProperty("DispatchActivityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIncidentRelatedPatol).GetField("<DispatchActivityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            dispatchActivityId.AddAnnotation("Relational:ColumnName", "dispatchActivityId");
            dispatchActivityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incWf = runtimeEntityType.AddProperty(
                "IncWf",
                typeof(Guid?),
                propertyInfo: typeof(ViewIncidentRelatedPatol).GetProperty("IncWf", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIncidentRelatedPatol).GetField("<IncWf>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            incWf.AddAnnotation("Relational:ColumnName", "IncWF");
            incWf.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentGeneratedNumber = runtimeEntityType.AddProperty(
                "IncidentGeneratedNumber",
                typeof(string),
                propertyInfo: typeof(ViewIncidentRelatedPatol).GetProperty("IncidentGeneratedNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIncidentRelatedPatol).GetField("<IncidentGeneratedNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            incidentGeneratedNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentId = runtimeEntityType.AddProperty(
                "IncidentId",
                typeof(long),
                propertyInfo: typeof(ViewIncidentRelatedPatol).GetProperty("IncidentId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIncidentRelatedPatol).GetField("<IncidentId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            incidentId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var patrolId = runtimeEntityType.AddProperty(
                "PatrolId",
                typeof(long),
                propertyInfo: typeof(ViewIncidentRelatedPatol).GetProperty("PatrolId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewIncidentRelatedPatol).GetField("<PatrolId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            patrolId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "ViewIncidentRelatedPatol");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
