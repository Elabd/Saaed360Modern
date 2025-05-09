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
    public partial class EventsSupervisorEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.EventsSupervisor",
                typeof(EventsSupervisor),
                baseEntityType,
                propertyCount: 7,
                navigationCount: 3,
                foreignKeyCount: 3,
                unnamedIndexCount: 3,
                keyCount: 1);

            var eventSupervisorId = runtimeEntityType.AddProperty(
                "EventSupervisorId",
                typeof(long),
                propertyInfo: typeof(EventsSupervisor).GetProperty("EventSupervisorId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EventsSupervisor).GetField("<EventSupervisorId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            eventSupervisorId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var createdBy = runtimeEntityType.AddProperty(
                "CreatedBy",
                typeof(long?),
                propertyInfo: typeof(EventsSupervisor).GetProperty("CreatedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EventsSupervisor).GetField("<CreatedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            createdBy.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var creationDateTime = runtimeEntityType.AddProperty(
                "CreationDateTime",
                typeof(DateTime?),
                propertyInfo: typeof(EventsSupervisor).GetProperty("CreationDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EventsSupervisor).GetField("<CreationDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            creationDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            creationDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var eventId = runtimeEntityType.AddProperty(
                "EventId",
                typeof(long?),
                propertyInfo: typeof(EventsSupervisor).GetProperty("EventId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EventsSupervisor).GetField("<EventId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            eventId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeteted = runtimeEntityType.AddProperty(
                "IsDeteted",
                typeof(bool?),
                propertyInfo: typeof(EventsSupervisor).GetProperty("IsDeteted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EventsSupervisor).GetField("<IsDeteted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            isDeteted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modificationDateTime = runtimeEntityType.AddProperty(
                "ModificationDateTime",
                typeof(DateTime?),
                propertyInfo: typeof(EventsSupervisor).GetProperty("ModificationDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EventsSupervisor).GetField("<ModificationDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            modificationDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            modificationDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personId = runtimeEntityType.AddProperty(
                "PersonId",
                typeof(long?),
                propertyInfo: typeof(EventsSupervisor).GetProperty("PersonId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EventsSupervisor).GetField("<PersonId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            personId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { eventSupervisorId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { createdBy });

            var index0 = runtimeEntityType.AddIndex(
                new[] { eventId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { personId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("CreatedBy") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonId") }),
                principalEntityType);

            var createdByNavigation = declaringEntityType.AddNavigation("CreatedByNavigation",
                runtimeForeignKey,
                onDependent: true,
                typeof(Person),
                propertyInfo: typeof(EventsSupervisor).GetProperty("CreatedByNavigation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EventsSupervisor).GetField("<CreatedByNavigation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var eventsSupervisorCreatedByNavigations = principalEntityType.AddNavigation("EventsSupervisorCreatedByNavigations",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<EventsSupervisor>),
                propertyInfo: typeof(Person).GetProperty("EventsSupervisorCreatedByNavigations", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Person).GetField("<EventsSupervisorCreatedByNavigations>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK__EventsSup__Creat__1F4B9E6C");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("EventId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("EventId") }),
                principalEntityType);

            var @event = declaringEntityType.AddNavigation("Event",
                runtimeForeignKey,
                onDependent: true,
                typeof(Event),
                propertyInfo: typeof(EventsSupervisor).GetProperty("Event", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EventsSupervisor).GetField("<Event>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var eventsSupervisors = principalEntityType.AddNavigation("EventsSupervisors",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<EventsSupervisor>),
                propertyInfo: typeof(Event).GetProperty("EventsSupervisors", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Event).GetField("<EventsSupervisors>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_EventsSupervisors_Events");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PersonId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonId") }),
                principalEntityType);

            var person = declaringEntityType.AddNavigation("Person",
                runtimeForeignKey,
                onDependent: true,
                typeof(Person),
                propertyInfo: typeof(EventsSupervisor).GetProperty("Person", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(EventsSupervisor).GetField("<Person>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var eventsSupervisorPeople = principalEntityType.AddNavigation("EventsSupervisorPeople",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<EventsSupervisor>),
                propertyInfo: typeof(Person).GetProperty("EventsSupervisorPeople", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Person).GetField("<EventsSupervisorPeople>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_EventsSupervisors_Person");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "EventsSupervisors");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
