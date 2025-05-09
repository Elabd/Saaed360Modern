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
    public partial class ConditionEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.Condition",
                typeof(Condition),
                baseEntityType,
                propertyCount: 5,
                navigationCount: 3,
                foreignKeyCount: 3,
                unnamedIndexCount: 2,
                keyCount: 1);

            var activityId = runtimeEntityType.AddProperty(
                "ActivityId",
                typeof(long),
                propertyInfo: typeof(Condition).GetProperty("ActivityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Condition).GetField("<ActivityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            activityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var conditionGroupId = runtimeEntityType.AddProperty(
                "ConditionGroupId",
                typeof(int),
                propertyInfo: typeof(Condition).GetProperty("ConditionGroupId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Condition).GetField("<ConditionGroupId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: 0);
            conditionGroupId.AddAnnotation("Relational:DefaultValue", 1);
            conditionGroupId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var conditionMandatoryIndicator = runtimeEntityType.AddProperty(
                "ConditionMandatoryIndicator",
                typeof(bool),
                propertyInfo: typeof(Condition).GetProperty("ConditionMandatoryIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Condition).GetField("<ConditionMandatoryIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            conditionMandatoryIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var conditionViolatedIndicator = runtimeEntityType.AddProperty(
                "ConditionViolatedIndicator",
                typeof(bool),
                propertyInfo: typeof(Condition).GetProperty("ConditionViolatedIndicator", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Condition).GetField("<ConditionViolatedIndicator>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: false);
            conditionViolatedIndicator.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var conditionViolationId = runtimeEntityType.AddProperty(
                "ConditionViolationId",
                typeof(int),
                propertyInfo: typeof(Condition).GetProperty("ConditionViolationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Condition).GetField("<ConditionViolationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: 0);
            conditionViolationId.AddAnnotation("Relational:DefaultValue", 1);
            conditionViolationId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { activityId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { conditionGroupId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { conditionViolationId });

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
                propertyInfo: typeof(Condition).GetProperty("Activity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Condition).GetField("<Activity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var condition = principalEntityType.AddNavigation("Condition",
                runtimeForeignKey,
                onDependent: false,
                typeof(Condition),
                propertyInfo: typeof(Activity).GetProperty("Condition", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Activity).GetField("<Condition>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Condition_Activity");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ConditionGroupId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ConditionGroupId") }),
                principalEntityType,
                required: true);

            var conditionGroup = declaringEntityType.AddNavigation("ConditionGroup",
                runtimeForeignKey,
                onDependent: true,
                typeof(ConditionGroupDim),
                propertyInfo: typeof(Condition).GetProperty("ConditionGroup", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Condition).GetField("<ConditionGroup>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var conditions = principalEntityType.AddNavigation("Conditions",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Condition>),
                propertyInfo: typeof(ConditionGroupDim).GetProperty("Conditions", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ConditionGroupDim).GetField("<Conditions>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Condition_ConditionGroupDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ConditionViolationId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ConditionViolationId") }),
                principalEntityType,
                required: true);

            var conditionViolation = declaringEntityType.AddNavigation("ConditionViolation",
                runtimeForeignKey,
                onDependent: true,
                typeof(ConditionViolationDim),
                propertyInfo: typeof(Condition).GetProperty("ConditionViolation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Condition).GetField("<ConditionViolation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var conditions = principalEntityType.AddNavigation("Conditions",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Condition>),
                propertyInfo: typeof(ConditionViolationDim).GetProperty("Conditions", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ConditionViolationDim).GetField("<Conditions>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Condition_ConditionViolationDIM");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Condition");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
