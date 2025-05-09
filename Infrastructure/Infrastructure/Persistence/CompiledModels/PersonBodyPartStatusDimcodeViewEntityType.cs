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
    public partial class PersonBodyPartStatusDimcodeViewEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.PersonBodyPartStatusDimcodeView",
                typeof(PersonBodyPartStatusDimcodeView),
                baseEntityType,
                propertyCount: 4);

            var isShown = runtimeEntityType.AddProperty(
                "IsShown",
                typeof(bool?),
                propertyInfo: typeof(PersonBodyPartStatusDimcodeView).GetProperty("IsShown", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonBodyPartStatusDimcodeView).GetField("<IsShown>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isShown.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personBodyPartStatusCode = runtimeEntityType.AddProperty(
                "PersonBodyPartStatusCode",
                typeof(string),
                propertyInfo: typeof(PersonBodyPartStatusDimcodeView).GetProperty("PersonBodyPartStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonBodyPartStatusDimcodeView).GetField("<PersonBodyPartStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 20);
            personBodyPartStatusCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personBodyPartStatusDescription = runtimeEntityType.AddProperty(
                "PersonBodyPartStatusDescription",
                typeof(string),
                propertyInfo: typeof(PersonBodyPartStatusDimcodeView).GetProperty("PersonBodyPartStatusDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonBodyPartStatusDimcodeView).GetField("<PersonBodyPartStatusDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 150);
            personBodyPartStatusDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusCode = runtimeEntityType.AddProperty(
                "RowStatusCode",
                typeof(string),
                propertyInfo: typeof(PersonBodyPartStatusDimcodeView).GetProperty("RowStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonBodyPartStatusDimcodeView).GetField("<RowStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            rowStatusCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewDefinitionSql", null);
            runtimeEntityType.AddAnnotation("Relational:ViewName", "PersonBodyPartStatusDIMCodeView");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
