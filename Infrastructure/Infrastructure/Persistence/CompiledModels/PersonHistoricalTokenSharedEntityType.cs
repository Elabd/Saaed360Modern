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
    public partial class PersonHistoricalTokenSharedEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.PersonHistoricalTokenShared",
                typeof(PersonHistoricalTokenShared),
                baseEntityType,
                propertyCount: 7,
                navigationCount: 2,
                foreignKeyCount: 2,
                unnamedIndexCount: 2,
                keyCount: 1);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(long),
                propertyInfo: typeof(PersonHistoricalTokenShared).GetProperty("Id", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonHistoricalTokenShared).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            id.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var createDateTime = runtimeEntityType.AddProperty(
                "CreateDateTime",
                typeof(DateTime),
                propertyInfo: typeof(PersonHistoricalTokenShared).GetProperty("CreateDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonHistoricalTokenShared).GetField("<CreateDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            createDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            createDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var eventId = runtimeEntityType.AddProperty(
                "EventId",
                typeof(long),
                propertyInfo: typeof(PersonHistoricalTokenShared).GetProperty("EventId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonHistoricalTokenShared).GetField("<EventId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            eventId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var expiryDateTime = runtimeEntityType.AddProperty(
                "ExpiryDateTime",
                typeof(DateTime),
                propertyInfo: typeof(PersonHistoricalTokenShared).GetProperty("ExpiryDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonHistoricalTokenShared).GetField("<ExpiryDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
            expiryDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            expiryDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool?),
                propertyInfo: typeof(PersonHistoricalTokenShared).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonHistoricalTokenShared).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personId = runtimeEntityType.AddProperty(
                "PersonId",
                typeof(long),
                propertyInfo: typeof(PersonHistoricalTokenShared).GetProperty("PersonId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonHistoricalTokenShared).GetField("<PersonId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            personId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var tokenGuid = runtimeEntityType.AddProperty(
                "TokenGuid",
                typeof(Guid),
                propertyInfo: typeof(PersonHistoricalTokenShared).GetProperty("TokenGuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonHistoricalTokenShared).GetField("<TokenGuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            tokenGuid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { id });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK_PersonHistoricalTokenShared");

            var index = runtimeEntityType.AddIndex(
                new[] { eventId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { personId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("EventId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("EventId") }),
                principalEntityType,
                required: true);

            var @event = declaringEntityType.AddNavigation("Event",
                runtimeForeignKey,
                onDependent: true,
                typeof(Event),
                propertyInfo: typeof(PersonHistoricalTokenShared).GetProperty("Event", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonHistoricalTokenShared).GetField("<Event>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personHistoricalTokenShareds = principalEntityType.AddNavigation("PersonHistoricalTokenShareds",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonHistoricalTokenShared>),
                propertyInfo: typeof(Event).GetProperty("PersonHistoricalTokenShareds", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Event).GetField("<PersonHistoricalTokenShareds>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonHistoricalTokenShareds_Events");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PersonId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonId") }),
                principalEntityType,
                required: true);

            var person = declaringEntityType.AddNavigation("Person",
                runtimeForeignKey,
                onDependent: true,
                typeof(Person),
                propertyInfo: typeof(PersonHistoricalTokenShared).GetProperty("Person", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonHistoricalTokenShared).GetField("<Person>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personHistoricalTokenShareds = principalEntityType.AddNavigation("PersonHistoricalTokenShareds",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonHistoricalTokenShared>),
                propertyInfo: typeof(Person).GetProperty("PersonHistoricalTokenShareds", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Person).GetField("<PersonHistoricalTokenShareds>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonHistoricalTokenShared_Person");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PersonHistoricalTokenShareds");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
