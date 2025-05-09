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
    public partial class TimeCategoryDimEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.TimeCategoryDim",
                typeof(TimeCategoryDim),
                baseEntityType,
                propertyCount: 6,
                navigationCount: 1,
                foreignKeyCount: 1,
                unnamedIndexCount: 1,
                keyCount: 1);

            var timeCategoryId = runtimeEntityType.AddProperty(
                "TimeCategoryId",
                typeof(int),
                propertyInfo: typeof(TimeCategoryDim).GetProperty("TimeCategoryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TimeCategoryDim).GetField("<TimeCategoryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0);
            timeCategoryId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var hoursRange = runtimeEntityType.AddProperty(
                "HoursRange",
                typeof(string),
                propertyInfo: typeof(TimeCategoryDim).GetProperty("HoursRange", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TimeCategoryDim).GetField("<HoursRange>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            hoursRange.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var minutesRange = runtimeEntityType.AddProperty(
                "MinutesRange",
                typeof(string),
                propertyInfo: typeof(TimeCategoryDim).GetProperty("MinutesRange", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TimeCategoryDim).GetField("<MinutesRange>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 50);
            minutesRange.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusId = runtimeEntityType.AddProperty(
                "RowStatusId",
                typeof(int?),
                propertyInfo: typeof(TimeCategoryDim).GetProperty("RowStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TimeCategoryDim).GetField("<RowStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            rowStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var valueInHours = runtimeEntityType.AddProperty(
                "ValueInHours",
                typeof(int?),
                propertyInfo: typeof(TimeCategoryDim).GetProperty("ValueInHours", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TimeCategoryDim).GetField("<ValueInHours>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            valueInHours.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var valueInMinutes = runtimeEntityType.AddProperty(
                "ValueInMinutes",
                typeof(int?),
                propertyInfo: typeof(TimeCategoryDim).GetProperty("ValueInMinutes", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TimeCategoryDim).GetField("<ValueInMinutes>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            valueInMinutes.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { timeCategoryId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { rowStatusId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("RowStatusId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("RowStatusId") }),
                principalEntityType);

            var rowStatus = declaringEntityType.AddNavigation("RowStatus",
                runtimeForeignKey,
                onDependent: true,
                typeof(RowStatusDim),
                propertyInfo: typeof(TimeCategoryDim).GetProperty("RowStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(TimeCategoryDim).GetField("<RowStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var timeCategoryDims = principalEntityType.AddNavigation("TimeCategoryDims",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<TimeCategoryDim>),
                propertyInfo: typeof(RowStatusDim).GetProperty("TimeCategoryDims", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RowStatusDim).GetField("<TimeCategoryDims>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_TimeCategoryDIM_RowStatusDIM");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "TimeCategoryDIM");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
