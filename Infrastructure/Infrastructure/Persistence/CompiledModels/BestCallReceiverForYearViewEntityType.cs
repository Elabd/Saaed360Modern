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
    public partial class BestCallReceiverForYearViewEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.BestCallReceiverForYearView",
                typeof(BestCallReceiverForYearView),
                baseEntityType,
                propertyCount: 7);

            var averageResponeseTime = runtimeEntityType.AddProperty(
                "AverageResponeseTime",
                typeof(TimeOnly?),
                propertyInfo: typeof(BestCallReceiverForYearView).GetProperty("AverageResponeseTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BestCallReceiverForYearView).GetField("<AverageResponeseTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                precision: 0);
            averageResponeseTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callReceiver = runtimeEntityType.AddProperty(
                "CallReceiver",
                typeof(string),
                propertyInfo: typeof(BestCallReceiverForYearView).GetProperty("CallReceiver", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BestCallReceiverForYearView).GetField("<CallReceiver>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 152);
            callReceiver.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callReceiverCode = runtimeEntityType.AddProperty(
                "CallReceiverCode",
                typeof(string),
                propertyInfo: typeof(BestCallReceiverForYearView).GetProperty("CallReceiverCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BestCallReceiverForYearView).GetField("<CallReceiverCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 100);
            callReceiverCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var callReceiverId = runtimeEntityType.AddProperty(
                "CallReceiverId",
                typeof(long),
                propertyInfo: typeof(BestCallReceiverForYearView).GetProperty("CallReceiverId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BestCallReceiverForYearView).GetField("<CallReceiverId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            callReceiverId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var controlCenter = runtimeEntityType.AddProperty(
                "ControlCenter",
                typeof(string),
                propertyInfo: typeof(BestCallReceiverForYearView).GetProperty("ControlCenter", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BestCallReceiverForYearView).GetField("<ControlCenter>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 250);
            controlCenter.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var image = runtimeEntityType.AddProperty(
                "Image",
                typeof(byte[]),
                propertyInfo: typeof(BestCallReceiverForYearView).GetProperty("Image", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BestCallReceiverForYearView).GetField("<Image>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            image.AddAnnotation("Relational:ColumnName", "image");
            image.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var noOfIncidents = runtimeEntityType.AddProperty(
                "NoOfIncidents",
                typeof(int?),
                propertyInfo: typeof(BestCallReceiverForYearView).GetProperty("NoOfIncidents", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(BestCallReceiverForYearView).GetField("<NoOfIncidents>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            noOfIncidents.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "BestCallReceiverForYearView");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
