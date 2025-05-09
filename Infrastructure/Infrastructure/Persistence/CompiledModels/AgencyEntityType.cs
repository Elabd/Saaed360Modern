﻿// <auto-generated />
using System;
using System.Collections.Generic;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

#pragma warning disable 219, 612, 618
#nullable disable

namespace Infrastructure.Persistence.CompiledModels
{
    [EntityFrameworkInternal]
    public partial class AgencyEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.Agency",
                typeof(Agency),
                baseEntityType,
                propertyCount: 4,
                navigationCount: 2,
                foreignKeyCount: 2,
                unnamedIndexCount: 1,
                keyCount: 1);

            var organizationId = runtimeEntityType.AddProperty(
                "OrganizationId",
                typeof(long),
                propertyInfo: typeof(Agency).GetProperty("OrganizationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Agency).GetField("<OrganizationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            organizationId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var agencyCategoryId = runtimeEntityType.AddProperty(
                "AgencyCategoryId",
                typeof(int),
                propertyInfo: typeof(Agency).GetProperty("AgencyCategoryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Agency).GetField("<AgencyCategoryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: 0);
            agencyCategoryId.AddAnnotation("Relational:DefaultValue", 1);
            agencyCategoryId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var identifier = runtimeEntityType.AddProperty(
                "Identifier",
                typeof(string),
                propertyInfo: typeof(Agency).GetProperty("Identifier", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Agency).GetField("<Identifier>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            identifier.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var ori = runtimeEntityType.AddProperty(
                "Ori",
                typeof(string),
                propertyInfo: typeof(Agency).GetProperty("Ori", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Agency).GetField("<Ori>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            ori.AddAnnotation("Relational:ColumnName", "ORI");
            ori.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { organizationId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { agencyCategoryId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AgencyCategoryId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AgencyCategoryId") }),
                principalEntityType,
                required: true);

            var agencyCategory = declaringEntityType.AddNavigation("AgencyCategory",
                runtimeForeignKey,
                onDependent: true,
                typeof(AgencyCategoryDim),
                propertyInfo: typeof(Agency).GetProperty("AgencyCategory", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Agency).GetField("<AgencyCategory>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var agencies = principalEntityType.AddNavigation("Agencies",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Agency>),
                propertyInfo: typeof(AgencyCategoryDim).GetProperty("Agencies", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AgencyCategoryDim).GetField("<Agencies>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Agency_AgencyCategory");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("OrganizationId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("OrganizationId") }),
                principalEntityType,
                unique: true,
                required: true);

            var organization = declaringEntityType.AddNavigation("Organization",
                runtimeForeignKey,
                onDependent: true,
                typeof(Organization),
                propertyInfo: typeof(Agency).GetProperty("Organization", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Agency).GetField("<Organization>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var agency = principalEntityType.AddNavigation("Agency",
                runtimeForeignKey,
                onDependent: false,
                typeof(Agency),
                propertyInfo: typeof(Organization).GetProperty("Agency", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Organization).GetField("<Agency>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Agency_Organization1");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Agency");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
