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
    public partial class ViewGetSupportOrganizationEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.ViewGetSupportOrganization",
                typeof(ViewGetSupportOrganization),
                baseEntityType,
                propertyCount: 5);

            var activityItemId = runtimeEntityType.AddProperty(
                "ActivityItemId",
                typeof(long),
                propertyInfo: typeof(ViewGetSupportOrganization).GetProperty("ActivityItemId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewGetSupportOrganization).GetField("<ActivityItemId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            activityItemId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemId = runtimeEntityType.AddProperty(
                "ItemId",
                typeof(long),
                propertyInfo: typeof(ViewGetSupportOrganization).GetProperty("ItemId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewGetSupportOrganization).GetField("<ItemId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            itemId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var name = runtimeEntityType.AddProperty(
                "Name",
                typeof(string),
                propertyInfo: typeof(ViewGetSupportOrganization).GetProperty("Name", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewGetSupportOrganization).GetField("<Name>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 250);
            name.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var organizationId = runtimeEntityType.AddProperty(
                "OrganizationId",
                typeof(long),
                propertyInfo: typeof(ViewGetSupportOrganization).GetProperty("OrganizationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewGetSupportOrganization).GetField("<OrganizationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            organizationId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var serialIdentification = runtimeEntityType.AddProperty(
                "SerialIdentification",
                typeof(string),
                propertyInfo: typeof(ViewGetSupportOrganization).GetProperty("SerialIdentification", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ViewGetSupportOrganization).GetField("<SerialIdentification>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            serialIdentification.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "ViewGetSupportOrganization");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
