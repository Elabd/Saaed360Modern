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
    public partial class AssessmentEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.Assessment",
                typeof(Assessment),
                baseEntityType,
                propertyCount: 4,
                navigationCount: 1,
                foreignKeyCount: 1,
                keyCount: 1);

            var activityId = runtimeEntityType.AddProperty(
                "ActivityId",
                typeof(long),
                propertyInfo: typeof(Assessment).GetProperty("ActivityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Assessment).GetField("<ActivityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            activityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var establishedDate = runtimeEntityType.AddProperty(
                "EstablishedDate",
                typeof(DateTime),
                propertyInfo: typeof(Assessment).GetProperty("EstablishedDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Assessment).GetField("<EstablishedDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            establishedDate.AddAnnotation("Relational:ColumnType", "datetime");
            establishedDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var expireDate = runtimeEntityType.AddProperty(
                "ExpireDate",
                typeof(DateTime),
                propertyInfo: typeof(Assessment).GetProperty("ExpireDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Assessment).GetField("<ExpireDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            expireDate.AddAnnotation("Relational:ColumnType", "datetime");
            expireDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var scoreText = runtimeEntityType.AddProperty(
                "ScoreText",
                typeof(string),
                propertyInfo: typeof(Assessment).GetProperty("ScoreText", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Assessment).GetField("<ScoreText>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 128);
            scoreText.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { activityId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__Assessme__45F4A791D64F8C96");

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
                propertyInfo: typeof(Assessment).GetProperty("Activity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Assessment).GetField("<Activity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var assessment = principalEntityType.AddNavigation("Assessment",
                runtimeForeignKey,
                onDependent: false,
                typeof(Assessment),
                propertyInfo: typeof(Activity).GetProperty("Assessment", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Activity).GetField("<Assessment>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Assessment_Activity");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Assessment");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
