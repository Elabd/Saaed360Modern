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
    public partial class LocationContactContainerViewEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.LocationContactContainerView",
                typeof(LocationContactContainerView),
                baseEntityType,
                propertyCount: 11);

            var contactId = runtimeEntityType.AddProperty(
                "ContactId",
                typeof(long),
                propertyInfo: typeof(LocationContactContainerView).GetProperty("ContactId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationContactContainerView).GetField("<ContactId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            contactId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var contactInvolvementCode = runtimeEntityType.AddProperty(
                "ContactInvolvementCode",
                typeof(string),
                propertyInfo: typeof(LocationContactContainerView).GetProperty("ContactInvolvementCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationContactContainerView).GetField("<ContactInvolvementCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            contactInvolvementCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var contactInvolvementDescription = runtimeEntityType.AddProperty(
                "ContactInvolvementDescription",
                typeof(string),
                propertyInfo: typeof(LocationContactContainerView).GetProperty("ContactInvolvementDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationContactContainerView).GetField("<ContactInvolvementDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            contactInvolvementDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createDateTimeStamp = runtimeEntityType.AddProperty(
                "CreateDateTimeStamp",
                typeof(DateTime?),
                propertyInfo: typeof(LocationContactContainerView).GetProperty("CreateDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationContactContainerView).GetField("<CreateDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            createDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            createDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var locationContactDescription = runtimeEntityType.AddProperty(
                "LocationContactDescription",
                typeof(string),
                propertyInfo: typeof(LocationContactContainerView).GetProperty("LocationContactDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationContactContainerView).GetField("<LocationContactDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 300);
            locationContactDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var locationContactId = runtimeEntityType.AddProperty(
                "LocationContactId",
                typeof(long),
                propertyInfo: typeof(LocationContactContainerView).GetProperty("LocationContactId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationContactContainerView).GetField("<LocationContactId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: 0L);
            locationContactId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var locationId = runtimeEntityType.AddProperty(
                "LocationId",
                typeof(long),
                propertyInfo: typeof(LocationContactContainerView).GetProperty("LocationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationContactContainerView).GetField("<LocationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            locationId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedDateTimeStamp = runtimeEntityType.AddProperty(
                "ModifiedDateTimeStamp",
                typeof(DateTime?),
                propertyInfo: typeof(LocationContactContainerView).GetProperty("ModifiedDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationContactContainerView).GetField("<ModifiedDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modifiedDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            modifiedDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusCode = runtimeEntityType.AddProperty(
                "RowStatusCode",
                typeof(string),
                propertyInfo: typeof(LocationContactContainerView).GetProperty("RowStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationContactContainerView).GetField("<RowStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            rowStatusCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusDescription = runtimeEntityType.AddProperty(
                "RowStatusDescription",
                typeof(string),
                propertyInfo: typeof(LocationContactContainerView).GetProperty("RowStatusDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationContactContainerView).GetField("<RowStatusDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50,
                unicode: false);
            rowStatusDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourceName = runtimeEntityType.AddProperty(
                "SourceName",
                typeof(string),
                propertyInfo: typeof(LocationContactContainerView).GetProperty("SourceName", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(LocationContactContainerView).GetField("<SourceName>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 100,
                unicode: false);
            sourceName.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "LocationContactContainerView");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
