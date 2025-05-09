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
    public partial class EnforcementOfficialCategoryDimcodeViewEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.EnforcementOfficialCategoryDimcodeView",
                typeof(EnforcementOfficialCategoryDimcodeView),
                baseEntityType,
                propertyCount: 4);

            var enforcementOfficialCategoryCode = runtimeEntityType.AddProperty(
                "EnforcementOfficialCategoryCode",
                typeof(string),
                propertyInfo: typeof(EnforcementOfficialCategoryDimcodeView).GetProperty("EnforcementOfficialCategoryCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficialCategoryDimcodeView).GetField("<EnforcementOfficialCategoryCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            enforcementOfficialCategoryCode.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var enforcementOfficialCategoryDescription = runtimeEntityType.AddProperty(
                "EnforcementOfficialCategoryDescription",
                typeof(string),
                propertyInfo: typeof(EnforcementOfficialCategoryDimcodeView).GetProperty("EnforcementOfficialCategoryDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficialCategoryDimcodeView).GetField("<EnforcementOfficialCategoryDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            enforcementOfficialCategoryDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isShown = runtimeEntityType.AddProperty(
                "IsShown",
                typeof(bool?),
                propertyInfo: typeof(EnforcementOfficialCategoryDimcodeView).GetProperty("IsShown", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficialCategoryDimcodeView).GetField("<IsShown>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isShown.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusCode = runtimeEntityType.AddProperty(
                "RowStatusCode",
                typeof(string),
                propertyInfo: typeof(EnforcementOfficialCategoryDimcodeView).GetProperty("RowStatusCode", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficialCategoryDimcodeView).GetField("<RowStatusCode>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
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
            runtimeEntityType.AddAnnotation("Relational:ViewName", "EnforcementOfficialCategoryDIMCodeView");
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
