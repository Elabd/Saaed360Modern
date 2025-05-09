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
    public partial class SetEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.Set",
                typeof(Set),
                baseEntityType,
                propertyCount: 4,
                namedIndexCount: 2,
                keyCount: 1);

            var key = runtimeEntityType.AddProperty(
                "Key",
                typeof(string),
                propertyInfo: typeof(Set).GetProperty("Key", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Set).GetField("<Key>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                maxLength: 100);
            key.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var value = runtimeEntityType.AddProperty(
                "Value",
                typeof(string),
                propertyInfo: typeof(Set).GetProperty("Value", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Set).GetField("<Value>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                maxLength: 256);
            value.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var expireAt = runtimeEntityType.AddProperty(
                "ExpireAt",
                typeof(DateTime?),
                propertyInfo: typeof(Set).GetProperty("ExpireAt", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Set).GetField("<ExpireAt>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            expireAt.AddAnnotation("Relational:ColumnType", "datetime");
            expireAt.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var score = runtimeEntityType.AddProperty(
                "Score",
                typeof(double),
                propertyInfo: typeof(Set).GetProperty("Score", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Set).GetField("<Score>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0.0);
            score.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key0 = runtimeEntityType.AddKey(
                new[] { key, value });
            runtimeEntityType.SetPrimaryKey(key0);
            key0.AddAnnotation("Relational:Name", "PK_HangFire_Set");

            var iX_HangFire_Set_ExpireAt = runtimeEntityType.AddIndex(
                new[] { expireAt },
                name: "IX_HangFire_Set_ExpireAt");
            iX_HangFire_Set_ExpireAt.AddAnnotation("Relational:Filter", "([ExpireAt] IS NOT NULL)");

            var iX_HangFire_Set_Score = runtimeEntityType.AddIndex(
                new[] { key, score },
                name: "IX_HangFire_Set_Score");

            return runtimeEntityType;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", "HangFire");
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Set");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
