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
    public partial class ObjectionRequestChannelDimEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.ObjectionRequestChannelDim",
                typeof(ObjectionRequestChannelDim),
                baseEntityType,
                propertyCount: 6,
                navigationCount: 2,
                keyCount: 1);

            var channelId = runtimeEntityType.AddProperty(
                "ChannelId",
                typeof(int),
                propertyInfo: typeof(ObjectionRequestChannelDim).GetProperty("ChannelId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ObjectionRequestChannelDim).GetField("<ChannelId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            channelId.AddAnnotation("Relational:ColumnName", "ChannelID");
            channelId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var afterPaymentReturnUrl = runtimeEntityType.AddProperty(
                "AfterPaymentReturnUrl",
                typeof(string),
                propertyInfo: typeof(ObjectionRequestChannelDim).GetProperty("AfterPaymentReturnUrl", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ObjectionRequestChannelDim).GetField("<AfterPaymentReturnUrl>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 500);
            afterPaymentReturnUrl.AddAnnotation("Relational:ColumnName", "AfterPaymentReturnURL");
            afterPaymentReturnUrl.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var channelArDesc = runtimeEntityType.AddProperty(
                "ChannelArDesc",
                typeof(string),
                propertyInfo: typeof(ObjectionRequestChannelDim).GetProperty("ChannelArDesc", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ObjectionRequestChannelDim).GetField("<ChannelArDesc>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            channelArDesc.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var channelDesc = runtimeEntityType.AddProperty(
                "ChannelDesc",
                typeof(string),
                propertyInfo: typeof(ObjectionRequestChannelDim).GetProperty("ChannelDesc", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ObjectionRequestChannelDim).GetField("<ChannelDesc>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            channelDesc.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var organizationDesc = runtimeEntityType.AddProperty(
                "OrganizationDesc",
                typeof(string),
                propertyInfo: typeof(ObjectionRequestChannelDim).GetProperty("OrganizationDesc", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ObjectionRequestChannelDim).GetField("<OrganizationDesc>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            organizationDesc.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var organizationId = runtimeEntityType.AddProperty(
                "OrganizationId",
                typeof(int?),
                propertyInfo: typeof(ObjectionRequestChannelDim).GetProperty("OrganizationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ObjectionRequestChannelDim).GetField("<OrganizationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            organizationId.AddAnnotation("Relational:ColumnName", "OrganizationID");
            organizationId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { channelId });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "ObjectionRequestChannelDIM");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
