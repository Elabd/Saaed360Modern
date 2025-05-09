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
    public partial class ViewMoiintegrationObjectionEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.ViewMoiintegrationObjection",
                typeof(ViewMoiintegrationObjection),
                baseEntityType,
                propertyCount: 12);

            var channelDesc = runtimeEntityType.AddProperty(
                "ChannelDesc",
                typeof(string),
                propertyInfo: typeof(ViewMoiintegrationObjection).GetProperty("ChannelDesc", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMoiintegrationObjection).GetField("<ChannelDesc>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 21);
            channelDesc.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emiratesId = runtimeEntityType.AddProperty(
                "EmiratesId",
                typeof(long?),
                propertyInfo: typeof(ViewMoiintegrationObjection).GetProperty("EmiratesId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMoiintegrationObjection).GetField("<EmiratesId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            emiratesId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var idtype = runtimeEntityType.AddProperty(
                "Idtype",
                typeof(int),
                propertyInfo: typeof(ViewMoiintegrationObjection).GetProperty("Idtype", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMoiintegrationObjection).GetField("<Idtype>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            idtype.AddAnnotation("Relational:ColumnName", "IDType");
            idtype.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var incidentSource = runtimeEntityType.AddProperty(
                "IncidentSource",
                typeof(int),
                propertyInfo: typeof(ViewMoiintegrationObjection).GetProperty("IncidentSource", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMoiintegrationObjection).GetField("<IncidentSource>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            incidentSource.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifyDate = runtimeEntityType.AddProperty(
                "ModifyDate",
                typeof(DateTime?),
                propertyInfo: typeof(ViewMoiintegrationObjection).GetProperty("ModifyDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMoiintegrationObjection).GetField("<ModifyDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modifyDate.AddAnnotation("Relational:ColumnType", "datetime");
            modifyDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var reportNumber = runtimeEntityType.AddProperty(
                "ReportNumber",
                typeof(string),
                propertyInfo: typeof(ViewMoiintegrationObjection).GetProperty("ReportNumber", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMoiintegrationObjection).GetField("<ReportNumber>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            reportNumber.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var serviceType = runtimeEntityType.AddProperty(
                "ServiceType",
                typeof(int),
                propertyInfo: typeof(ViewMoiintegrationObjection).GetProperty("ServiceType", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMoiintegrationObjection).GetField("<ServiceType>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            serviceType.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var startDate = runtimeEntityType.AddProperty(
                "StartDate",
                typeof(DateTime?),
                propertyInfo: typeof(ViewMoiintegrationObjection).GetProperty("StartDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMoiintegrationObjection).GetField("<StartDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            startDate.AddAnnotation("Relational:ColumnType", "datetime");
            startDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var status = runtimeEntityType.AddProperty(
                "Status",
                typeof(string),
                propertyInfo: typeof(ViewMoiintegrationObjection).GetProperty("Status", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMoiintegrationObjection).GetField("<Status>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100);
            status.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var subIncidentSource = runtimeEntityType.AddProperty(
                "SubIncidentSource",
                typeof(int),
                propertyInfo: typeof(ViewMoiintegrationObjection).GetProperty("SubIncidentSource", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMoiintegrationObjection).GetField("<SubIncidentSource>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            subIncidentSource.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var timeToFinish = runtimeEntityType.AddProperty(
                "TimeToFinish",
                typeof(int?),
                propertyInfo: typeof(ViewMoiintegrationObjection).GetProperty("TimeToFinish", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMoiintegrationObjection).GetField("<TimeToFinish>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            timeToFinish.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var trafficCode = runtimeEntityType.AddProperty(
                "TrafficCode",
                typeof(string),
                propertyInfo: typeof(ViewMoiintegrationObjection).GetProperty("TrafficCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewMoiintegrationObjection).GetField("<TrafficCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 3000);
            trafficCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "ViewMOIIntegrationObjections");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
