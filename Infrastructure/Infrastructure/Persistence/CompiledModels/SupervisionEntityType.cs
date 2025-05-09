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
    public partial class SupervisionEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.Supervision",
                typeof(Supervision),
                baseEntityType,
                propertyCount: 6,
                navigationCount: 5,
                foreignKeyCount: 5,
                unnamedIndexCount: 4,
                keyCount: 1);

            var activityId = runtimeEntityType.AddProperty(
                "ActivityId",
                typeof(long),
                propertyInfo: typeof(Supervision).GetProperty("ActivityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Supervision).GetField("<ActivityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            activityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var facilityBedAssignmentId = runtimeEntityType.AddProperty(
                "FacilityBedAssignmentId",
                typeof(int),
                propertyInfo: typeof(Supervision).GetProperty("FacilityBedAssignmentId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Supervision).GetField("<FacilityBedAssignmentId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            facilityBedAssignmentId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var supervisionCategoryId = runtimeEntityType.AddProperty(
                "SupervisionCategoryId",
                typeof(int),
                propertyInfo: typeof(Supervision).GetProperty("SupervisionCategoryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Supervision).GetField("<SupervisionCategoryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            supervisionCategoryId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var supervisionCustodyStatusId = runtimeEntityType.AddProperty(
                "SupervisionCustodyStatusId",
                typeof(int),
                propertyInfo: typeof(Supervision).GetProperty("SupervisionCustodyStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Supervision).GetField("<SupervisionCustodyStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            supervisionCustodyStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var supervisionMandatoryIndicator = runtimeEntityType.AddProperty(
                "SupervisionMandatoryIndicator",
                typeof(bool),
                propertyInfo: typeof(Supervision).GetProperty("SupervisionMandatoryIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Supervision).GetField("<SupervisionMandatoryIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            supervisionMandatoryIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var supervisionStatusId = runtimeEntityType.AddProperty(
                "SupervisionStatusId",
                typeof(int),
                propertyInfo: typeof(Supervision).GetProperty("SupervisionStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Supervision).GetField("<SupervisionStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0);
            supervisionStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { activityId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { facilityBedAssignmentId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { supervisionCategoryId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { supervisionCustodyStatusId });

            var index2 = runtimeEntityType.AddIndex(
                new[] { supervisionStatusId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ActivityId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ActivityId") }),
                principalEntityType,
                unique: true,
                required: true);

            var activity = declaringEntityType.AddNavigation("Activity",
                runtimeForeignKey,
                onDependent: true,
                typeof(Activity),
                propertyInfo: typeof(Supervision).GetProperty("Activity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Supervision).GetField("<Activity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var supervision = principalEntityType.AddNavigation("Supervision",
                runtimeForeignKey,
                onDependent: false,
                typeof(Supervision),
                propertyInfo: typeof(Activity).GetProperty("Supervision", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Activity).GetField("<Supervision>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Supervision_Activity");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("FacilityBedAssignmentId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("FacilityBedAssignmentId") }),
                principalEntityType,
                required: true);

            var facilityBedAssignment = declaringEntityType.AddNavigation("FacilityBedAssignment",
                runtimeForeignKey,
                onDependent: true,
                typeof(FacilityBedAssignmentDim),
                propertyInfo: typeof(Supervision).GetProperty("FacilityBedAssignment", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Supervision).GetField("<FacilityBedAssignment>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var supervisions = principalEntityType.AddNavigation("Supervisions",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Supervision>),
                propertyInfo: typeof(FacilityBedAssignmentDim).GetProperty("Supervisions", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(FacilityBedAssignmentDim).GetField("<Supervisions>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Supervision_FacilityBedAssignementDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("SupervisionCategoryId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("SupervisionCategoryId") }),
                principalEntityType,
                required: true);

            var supervisionCategory = declaringEntityType.AddNavigation("SupervisionCategory",
                runtimeForeignKey,
                onDependent: true,
                typeof(SupervisionCategoryDim),
                propertyInfo: typeof(Supervision).GetProperty("SupervisionCategory", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Supervision).GetField("<SupervisionCategory>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var supervisions = principalEntityType.AddNavigation("Supervisions",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Supervision>),
                propertyInfo: typeof(SupervisionCategoryDim).GetProperty("Supervisions", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SupervisionCategoryDim).GetField("<Supervisions>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Supervision_SupervisionCategoryDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("SupervisionCustodyStatusId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("SupervisionCustodyStatusId") }),
                principalEntityType,
                required: true);

            var supervisionCustodyStatus = declaringEntityType.AddNavigation("SupervisionCustodyStatus",
                runtimeForeignKey,
                onDependent: true,
                typeof(SupervisionCustodyStatusDim),
                propertyInfo: typeof(Supervision).GetProperty("SupervisionCustodyStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Supervision).GetField("<SupervisionCustodyStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var supervisions = principalEntityType.AddNavigation("Supervisions",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Supervision>),
                propertyInfo: typeof(SupervisionCustodyStatusDim).GetProperty("Supervisions", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SupervisionCustodyStatusDim).GetField("<Supervisions>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Supervision_SupervisionCustodyStatusDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey5(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("SupervisionStatusId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("SupervisionStatusId") }),
                principalEntityType,
                required: true);

            var supervisionStatus = declaringEntityType.AddNavigation("SupervisionStatus",
                runtimeForeignKey,
                onDependent: true,
                typeof(SupervisionStatusDim),
                propertyInfo: typeof(Supervision).GetProperty("SupervisionStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Supervision).GetField("<SupervisionStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var supervisions = principalEntityType.AddNavigation("Supervisions",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Supervision>),
                propertyInfo: typeof(SupervisionStatusDim).GetProperty("Supervisions", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(SupervisionStatusDim).GetField("<Supervisions>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Supervision_SupervisionStatusDIM");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Supervision");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
