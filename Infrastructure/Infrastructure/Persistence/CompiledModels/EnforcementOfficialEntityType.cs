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
    public partial class EnforcementOfficialEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.EnforcementOfficial",
                typeof(EnforcementOfficial),
                baseEntityType,
                propertyCount: 6,
                navigationCount: 3,
                foreignKeyCount: 3,
                unnamedIndexCount: 2,
                keyCount: 1);

            var personId = runtimeEntityType.AddProperty(
                "PersonId",
                typeof(long),
                propertyInfo: typeof(EnforcementOfficial).GetProperty("PersonId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficial).GetField("<PersonId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            personId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var enforcementOfficialAsnCategoryId = runtimeEntityType.AddProperty(
                "EnforcementOfficialAsnCategoryId",
                typeof(int),
                propertyInfo: typeof(EnforcementOfficial).GetProperty("EnforcementOfficialAsnCategoryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficial).GetField("<EnforcementOfficialAsnCategoryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            enforcementOfficialAsnCategoryId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var enforcementOfficialBadgeIdentification = runtimeEntityType.AddProperty(
                "EnforcementOfficialBadgeIdentification",
                typeof(string),
                propertyInfo: typeof(EnforcementOfficial).GetProperty("EnforcementOfficialBadgeIdentification", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficial).GetField("<EnforcementOfficialBadgeIdentification>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50);
            enforcementOfficialBadgeIdentification.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var enforcementOfficialCategoryId = runtimeEntityType.AddProperty(
                "EnforcementOfficialCategoryId",
                typeof(int),
                propertyInfo: typeof(EnforcementOfficial).GetProperty("EnforcementOfficialCategoryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficial).GetField("<EnforcementOfficialCategoryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            enforcementOfficialCategoryId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var enforcementOfficialPostLicenseIdent = runtimeEntityType.AddProperty(
                "EnforcementOfficialPostLicenseIdent",
                typeof(string),
                propertyInfo: typeof(EnforcementOfficial).GetProperty("EnforcementOfficialPostLicenseIdent", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficial).GetField("<EnforcementOfficialPostLicenseIdent>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50);
            enforcementOfficialPostLicenseIdent.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var enforcementOfficialUnit = runtimeEntityType.AddProperty(
                "EnforcementOfficialUnit",
                typeof(string),
                propertyInfo: typeof(EnforcementOfficial).GetProperty("EnforcementOfficialUnit", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficial).GetField("<EnforcementOfficialUnit>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 50);
            enforcementOfficialUnit.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { personId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { enforcementOfficialAsnCategoryId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { enforcementOfficialCategoryId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("EnforcementOfficialAsnCategoryId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("EnforcementOfficialAsnCategoryId") }),
                principalEntityType,
                required: true);

            var enforcementOfficialAsnCategory = declaringEntityType.AddNavigation("EnforcementOfficialAsnCategory",
                runtimeForeignKey,
                onDependent: true,
                typeof(EnforcementOfficialAsnCategoryDim),
                propertyInfo: typeof(EnforcementOfficial).GetProperty("EnforcementOfficialAsnCategory", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficial).GetField("<EnforcementOfficialAsnCategory>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var enforcementOfficials = principalEntityType.AddNavigation("EnforcementOfficials",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<EnforcementOfficial>),
                propertyInfo: typeof(EnforcementOfficialAsnCategoryDim).GetProperty("EnforcementOfficials", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficialAsnCategoryDim).GetField("<EnforcementOfficials>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_EnforcementOffical_EnforcementOfficalAssignmentCategoryDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("EnforcementOfficialCategoryId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("EnforcementOfficialCategoryId") }),
                principalEntityType,
                required: true);

            var enforcementOfficialCategory = declaringEntityType.AddNavigation("EnforcementOfficialCategory",
                runtimeForeignKey,
                onDependent: true,
                typeof(EnforcementOfficialCategoryDim),
                propertyInfo: typeof(EnforcementOfficial).GetProperty("EnforcementOfficialCategory", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficial).GetField("<EnforcementOfficialCategory>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var enforcementOfficials = principalEntityType.AddNavigation("EnforcementOfficials",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<EnforcementOfficial>),
                propertyInfo: typeof(EnforcementOfficialCategoryDim).GetProperty("EnforcementOfficials", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficialCategoryDim).GetField("<EnforcementOfficials>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_EnforcementOffical_EnforcementOfficalCategoryDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PersonId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonId") }),
                principalEntityType,
                unique: true,
                required: true);

            var person = declaringEntityType.AddNavigation("Person",
                runtimeForeignKey,
                onDependent: true,
                typeof(Person),
                propertyInfo: typeof(EnforcementOfficial).GetProperty("Person", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EnforcementOfficial).GetField("<Person>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var enforcementOfficial = principalEntityType.AddNavigation("EnforcementOfficial",
                runtimeForeignKey,
                onDependent: false,
                typeof(EnforcementOfficial),
                propertyInfo: typeof(Person).GetProperty("EnforcementOfficial", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Person).GetField("<EnforcementOfficial>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_EnforcementOffical_Person");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "EnforcementOfficial");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
