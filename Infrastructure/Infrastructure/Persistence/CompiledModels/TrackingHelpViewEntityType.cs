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
    public partial class TrackingHelpViewEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.TrackingHelpView",
                typeof(TrackingHelpView),
                baseEntityType,
                propertyCount: 9);

            var accidentLatitude = runtimeEntityType.AddProperty(
                "AccidentLatitude",
                typeof(double?),
                propertyInfo: typeof(TrackingHelpView).GetProperty("AccidentLatitude", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TrackingHelpView).GetField("<AccidentLatitude>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            accidentLatitude.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var accidentLongitude = runtimeEntityType.AddProperty(
                "AccidentLongitude",
                typeof(double?),
                propertyInfo: typeof(TrackingHelpView).GetProperty("AccidentLongitude", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TrackingHelpView).GetField("<AccidentLongitude>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            accidentLongitude.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var activityId = runtimeEntityType.AddProperty(
                "ActivityId",
                typeof(long),
                propertyInfo: typeof(TrackingHelpView).GetProperty("ActivityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TrackingHelpView).GetField("<ActivityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            activityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var activityItemStatusId = runtimeEntityType.AddProperty(
                "ActivityItemStatusId",
                typeof(long?),
                propertyInfo: typeof(TrackingHelpView).GetProperty("ActivityItemStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TrackingHelpView).GetField("<ActivityItemStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            activityItemStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var activityStatusId = runtimeEntityType.AddProperty(
                "ActivityStatusId",
                typeof(int),
                propertyInfo: typeof(TrackingHelpView).GetProperty("ActivityStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TrackingHelpView).GetField("<ActivityStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            activityStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var activityTransactionStatusId = runtimeEntityType.AddProperty(
                "ActivityTransactionStatusId",
                typeof(int?),
                propertyInfo: typeof(TrackingHelpView).GetProperty("ActivityTransactionStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TrackingHelpView).GetField("<ActivityTransactionStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            activityTransactionStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var patrolLatitude = runtimeEntityType.AddProperty(
                "PatrolLatitude",
                typeof(double?),
                propertyInfo: typeof(TrackingHelpView).GetProperty("PatrolLatitude", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TrackingHelpView).GetField("<PatrolLatitude>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            patrolLatitude.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var patrolLongitude = runtimeEntityType.AddProperty(
                "PatrolLongitude",
                typeof(double?),
                propertyInfo: typeof(TrackingHelpView).GetProperty("PatrolLongitude", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TrackingHelpView).GetField("<PatrolLongitude>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            patrolLongitude.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var patrolName = runtimeEntityType.AddProperty(
                "PatrolName",
                typeof(string),
                propertyInfo: typeof(TrackingHelpView).GetProperty("PatrolName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TrackingHelpView).GetField("<PatrolName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            patrolName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "TrackingHelpView");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
