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
    public partial class PersonInjuryEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.PersonInjury",
                typeof(PersonInjury),
                baseEntityType,
                propertyCount: 24,
                navigationCount: 11,
                foreignKeyCount: 10,
                unnamedIndexCount: 10,
                keyCount: 1);

            var personInjuryId = runtimeEntityType.AddProperty(
                "PersonInjuryId",
                typeof(long),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonInjuryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonInjuryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            personInjuryId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var coronerNotified = runtimeEntityType.AddProperty(
                "CoronerNotified",
                typeof(bool?),
                propertyInfo: typeof(PersonInjury).GetProperty("CoronerNotified", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<CoronerNotified>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            coronerNotified.AddAnnotation("Relational:DefaultValue", false);
            coronerNotified.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var createDateTimeStamp = runtimeEntityType.AddProperty(
                "CreateDateTimeStamp",
                typeof(DateTime?),
                propertyInfo: typeof(PersonInjury).GetProperty("CreateDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<CreateDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            createDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            createDateTimeStamp.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            createDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emsarrivedDateTime = runtimeEntityType.AddProperty(
                "EmsarrivedDateTime",
                typeof(DateTime?),
                propertyInfo: typeof(PersonInjury).GetProperty("EmsarrivedDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<EmsarrivedDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            emsarrivedDateTime.AddAnnotation("Relational:ColumnName", "EMSArrivedDateTime");
            emsarrivedDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            emsarrivedDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var emsnotifiedDateTime = runtimeEntityType.AddProperty(
                "EmsnotifiedDateTime",
                typeof(DateTime?),
                propertyInfo: typeof(PersonInjury).GetProperty("EmsnotifiedDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<EmsnotifiedDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            emsnotifiedDateTime.AddAnnotation("Relational:ColumnName", "EMSNotifiedDateTime");
            emsnotifiedDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            emsnotifiedDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDead = runtimeEntityType.AddProperty(
                "IsDead",
                typeof(bool?),
                propertyInfo: typeof(PersonInjury).GetProperty("IsDead", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<IsDead>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            isDead.AddAnnotation("Relational:DefaultValue", false);
            isDead.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool?),
                propertyInfo: typeof(PersonInjury).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            isDeleted.AddAnnotation("Relational:DefaultValue", false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isInjured = runtimeEntityType.AddProperty(
                "IsInjured",
                typeof(bool?),
                propertyInfo: typeof(PersonInjury).GetProperty("IsInjured", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<IsInjured>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            isInjured.AddAnnotation("Relational:DefaultValue", false);
            isInjured.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var kinNotified = runtimeEntityType.AddProperty(
                "KinNotified",
                typeof(bool?),
                propertyInfo: typeof(PersonInjury).GetProperty("KinNotified", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<KinNotified>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            kinNotified.AddAnnotation("Relational:DefaultValue", false);
            kinNotified.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedDateTimeStamp = runtimeEntityType.AddProperty(
                "ModifiedDateTimeStamp",
                typeof(DateTime?),
                propertyInfo: typeof(PersonInjury).GetProperty("ModifiedDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<ModifiedDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            modifiedDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            modifiedDateTimeStamp.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            modifiedDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personGuid = runtimeEntityType.AddProperty(
                "PersonGuid",
                typeof(Guid),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonGuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonGuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            personGuid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personId = runtimeEntityType.AddProperty(
                "PersonId",
                typeof(long),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            personId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personInjuryDescription = runtimeEntityType.AddProperty(
                "PersonInjuryDescription",
                typeof(string),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonInjuryDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonInjuryDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 300);
            personInjuryDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personInjuryGuid = runtimeEntityType.AddProperty(
                "PersonInjuryGuid",
                typeof(Guid),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonInjuryGuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonInjuryGuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            personInjuryGuid.AddAnnotation("Relational:DefaultValueSql", "(newid())");
            personInjuryGuid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personInjuryLevelId = runtimeEntityType.AddProperty(
                "PersonInjuryLevelId",
                typeof(int?),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonInjuryLevelId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonInjuryLevelId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            personInjuryLevelId.AddAnnotation("Relational:DefaultValue", 1);
            personInjuryLevelId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personInjuryListId = runtimeEntityType.AddProperty(
                "PersonInjuryListId",
                typeof(int?),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonInjuryListId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonInjuryListId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            personInjuryListId.AddAnnotation("Relational:DefaultValue", 1);
            personInjuryListId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personMedicalById = runtimeEntityType.AddProperty(
                "PersonMedicalById",
                typeof(int?),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonMedicalById", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonMedicalById>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            personMedicalById.AddAnnotation("Relational:DefaultValue", 1);
            personMedicalById.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personMedicationId = runtimeEntityType.AddProperty(
                "PersonMedicationId",
                typeof(int?),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonMedicationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonMedicationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            personMedicationId.AddAnnotation("Relational:DefaultValue", 1);
            personMedicationId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personMoruaryId = runtimeEntityType.AddProperty(
                "PersonMoruaryId",
                typeof(int?),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonMoruaryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonMoruaryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            personMoruaryId.AddAnnotation("Relational:DefaultValue", 1);
            personMoruaryId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personPhysicianId = runtimeEntityType.AddProperty(
                "PersonPhysicianId",
                typeof(int?),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonPhysicianId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonPhysicianId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            personPhysicianId.AddAnnotation("Relational:DefaultValue", 1);
            personPhysicianId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var personTransportedById = runtimeEntityType.AddProperty(
                "PersonTransportedById",
                typeof(int?),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonTransportedById", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonTransportedById>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            personTransportedById.AddAnnotation("Relational:DefaultValue", 1);
            personTransportedById.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var pronouncedDateTime = runtimeEntityType.AddProperty(
                "PronouncedDateTime",
                typeof(DateTime?),
                propertyInfo: typeof(PersonInjury).GetProperty("PronouncedDateTime", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PronouncedDateTime>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            pronouncedDateTime.AddAnnotation("Relational:ColumnType", "datetime");
            pronouncedDateTime.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusId = runtimeEntityType.AddProperty(
                "RowStatusId",
                typeof(int?),
                propertyInfo: typeof(PersonInjury).GetProperty("RowStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<RowStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            rowStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourceId = runtimeEntityType.AddProperty(
                "SourceId",
                typeof(long),
                propertyInfo: typeof(PersonInjury).GetProperty("SourceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<SourceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            sourceId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { personInjuryId });
            runtimeEntityType.SetPrimaryKey(key);
            key.AddAnnotation("Relational:Name", "PK__PersonIn__6FE58C29A3979109");

            var index = runtimeEntityType.AddIndex(
                new[] { personId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { personInjuryLevelId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { personInjuryListId });

            var index2 = runtimeEntityType.AddIndex(
                new[] { personMedicalById });

            var index3 = runtimeEntityType.AddIndex(
                new[] { personMedicationId });

            var index4 = runtimeEntityType.AddIndex(
                new[] { personMoruaryId });

            var index5 = runtimeEntityType.AddIndex(
                new[] { personPhysicianId });

            var index6 = runtimeEntityType.AddIndex(
                new[] { personTransportedById });

            var index7 = runtimeEntityType.AddIndex(
                new[] { rowStatusId });

            var index8 = runtimeEntityType.AddIndex(
                new[] { sourceId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PersonId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonId") }),
                principalEntityType,
                required: true);

            var person = declaringEntityType.AddNavigation("Person",
                runtimeForeignKey,
                onDependent: true,
                typeof(Person),
                propertyInfo: typeof(PersonInjury).GetProperty("Person", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<Person>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personInjuries = principalEntityType.AddNavigation("PersonInjuries",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonInjury>),
                propertyInfo: typeof(Person).GetProperty("PersonInjuries", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Person).GetField("<PersonInjuries>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonInjury_Person");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PersonInjuryLevelId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonInjuryLevelId") }),
                principalEntityType);

            var personInjuryLevel = declaringEntityType.AddNavigation("PersonInjuryLevel",
                runtimeForeignKey,
                onDependent: true,
                typeof(PersonInjuryLevelDim),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonInjuryLevel", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonInjuryLevel>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personInjuries = principalEntityType.AddNavigation("PersonInjuries",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonInjury>),
                propertyInfo: typeof(PersonInjuryLevelDim).GetProperty("PersonInjuries", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjuryLevelDim).GetField("<PersonInjuries>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonInjury_PersonInjuryLevelDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PersonInjuryListId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonInjuryListId") }),
                principalEntityType);

            var personInjuryList = declaringEntityType.AddNavigation("PersonInjuryList",
                runtimeForeignKey,
                onDependent: true,
                typeof(PersonInjuryListDim),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonInjuryList", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonInjuryList>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personInjuries = principalEntityType.AddNavigation("PersonInjuries",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonInjury>),
                propertyInfo: typeof(PersonInjuryListDim).GetProperty("PersonInjuries", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjuryListDim).GetField("<PersonInjuries>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonInjury_PersonInjuryListDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PersonMedicalById") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonMedicalById") }),
                principalEntityType);

            var personMedicalBy = declaringEntityType.AddNavigation("PersonMedicalBy",
                runtimeForeignKey,
                onDependent: true,
                typeof(PersonMedicalByDim),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonMedicalBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonMedicalBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personInjuries = principalEntityType.AddNavigation("PersonInjuries",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonInjury>),
                propertyInfo: typeof(PersonMedicalByDim).GetProperty("PersonInjuries", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonMedicalByDim).GetField("<PersonInjuries>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonInjury_PersonMedicalByDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey5(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PersonMedicationId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonMedicationId") }),
                principalEntityType);

            var personMedication = declaringEntityType.AddNavigation("PersonMedication",
                runtimeForeignKey,
                onDependent: true,
                typeof(PersonMedicationDim),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonMedication", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonMedication>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personInjuries = principalEntityType.AddNavigation("PersonInjuries",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonInjury>),
                propertyInfo: typeof(PersonMedicationDim).GetProperty("PersonInjuries", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonMedicationDim).GetField("<PersonInjuries>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonInjury_PersonMedicationDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey6(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PersonMoruaryId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonMoruaryId") }),
                principalEntityType);

            var personMoruary = declaringEntityType.AddNavigation("PersonMoruary",
                runtimeForeignKey,
                onDependent: true,
                typeof(PersonMoruaryDim),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonMoruary", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonMoruary>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personInjuries = principalEntityType.AddNavigation("PersonInjuries",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonInjury>),
                propertyInfo: typeof(PersonMoruaryDim).GetProperty("PersonInjuries", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonMoruaryDim).GetField("<PersonInjuries>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonInjury_PersonMoruaryDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey7(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PersonPhysicianId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonPhysicianId") }),
                principalEntityType);

            var personPhysician = declaringEntityType.AddNavigation("PersonPhysician",
                runtimeForeignKey,
                onDependent: true,
                typeof(PersonPhysicianDim),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonPhysician", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonPhysician>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personInjuries = principalEntityType.AddNavigation("PersonInjuries",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonInjury>),
                propertyInfo: typeof(PersonPhysicianDim).GetProperty("PersonInjuries", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonPhysicianDim).GetField("<PersonInjuries>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonInjury_PersonPhysicianDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey8(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PersonTransportedById") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("PersonTransportedById") }),
                principalEntityType);

            var personTransportedBy = declaringEntityType.AddNavigation("PersonTransportedBy",
                runtimeForeignKey,
                onDependent: true,
                typeof(PersonTransportedByDim),
                propertyInfo: typeof(PersonInjury).GetProperty("PersonTransportedBy", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<PersonTransportedBy>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personInjuries = principalEntityType.AddNavigation("PersonInjuries",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonInjury>),
                propertyInfo: typeof(PersonTransportedByDim).GetProperty("PersonInjuries", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonTransportedByDim).GetField("<PersonInjuries>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonInjury_PersonTransportedByDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey9(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("RowStatusId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("RowStatusId") }),
                principalEntityType);

            var rowStatus = declaringEntityType.AddNavigation("RowStatus",
                runtimeForeignKey,
                onDependent: true,
                typeof(RowStatusDim),
                propertyInfo: typeof(PersonInjury).GetProperty("RowStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<RowStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personInjuries = principalEntityType.AddNavigation("PersonInjuries",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonInjury>),
                propertyInfo: typeof(RowStatusDim).GetProperty("PersonInjuries", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RowStatusDim).GetField("<PersonInjuries>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonInjury_RowStatusDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey10(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("SourceId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("SourceId") }),
                principalEntityType,
                required: true);

            var source = declaringEntityType.AddNavigation("Source",
                runtimeForeignKey,
                onDependent: true,
                typeof(Source),
                propertyInfo: typeof(PersonInjury).GetProperty("Source", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(PersonInjury).GetField("<Source>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var personInjuries = principalEntityType.AddNavigation("PersonInjuries",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<PersonInjury>),
                propertyInfo: typeof(Source).GetProperty("PersonInjuries", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Source).GetField("<PersonInjuries>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_PersonInjury_Source");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PersonInjury");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
