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
    public partial class PersonAreaEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.PersonArea",
                typeof(PersonArea),
                baseEntityType,
                propertyCount: 3,
                navigationCount: 2,
                foreignKeyCount: 2,
                unnamedIndexCount: 1,
                namedIndexCount: 1,
                keyCount: 1);

            var personAreaId = runtimeEntityType.AddProperty(
                "PersonAreaId",
                typeof(long),
                propertyInfo: typeof(PersonArea).GetProperty("PersonAreaId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonArea).GetField("<PersonAreaId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            personAreaId.AddAnnotation("Relational:ColumnName", "personAreaId");
            personAreaId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var areaId = runtimeEntityType.AddProperty(
                "AreaId",
                typeof(long?),
                propertyInfo: typeof(PersonArea).GetProperty("AreaId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonArea).GetField("<AreaId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            areaId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personId = runtimeEntityType.AddProperty(
                "PersonId",
                typeof(long?),
                propertyInfo: typeof(PersonArea).GetProperty("PersonId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonArea).GetField("<PersonId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            personId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { personAreaId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { areaId });

            var nonClusteredIndex20200531151217 = runtimeEntityType.AddIndex(
                new[] { personId },
                name: "NonClusteredIndex-20200531-151217");

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AreaId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AreaId") }),
                principalEntityType);

            var area = declaringEntityType.AddNavigation("Area",
                runtimeForeignKey,
                onDependent: true,
                typeof(Area),
                propertyInfo: typeof(PersonArea).GetProperty("Area", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonArea).GetField("<Area>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personAreas = principalEntityType.AddNavigation("PersonAreas",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonArea>),
                propertyInfo: typeof(Area).GetProperty("PersonAreas", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Area).GetField("<PersonAreas>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonArea_Area");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PersonId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonId") }),
                principalEntityType);

            var person = declaringEntityType.AddNavigation("Person",
                runtimeForeignKey,
                onDependent: true,
                typeof(Person),
                propertyInfo: typeof(PersonArea).GetProperty("Person", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonArea).GetField("<Person>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personAreas = principalEntityType.AddNavigation("PersonAreas",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonArea>),
                propertyInfo: typeof(Person).GetProperty("PersonAreas", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Person).GetField("<PersonAreas>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonArea_Person");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PersonArea");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
