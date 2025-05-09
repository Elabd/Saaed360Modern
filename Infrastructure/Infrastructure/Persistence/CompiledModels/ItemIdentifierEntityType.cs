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
    public partial class ItemIdentifierEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.ItemIdentifier",
                typeof(ItemIdentifier),
                baseEntityType,
                propertyCount: 12,
                navigationCount: 5,
                foreignKeyCount: 5,
                unnamedIndexCount: 5,
                keyCount: 1);

            var itemIdentifierId = runtimeEntityType.AddProperty(
                "ItemIdentifierId",
                typeof(long),
                propertyInfo: typeof(ItemIdentifier).GetProperty("ItemIdentifierId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<ItemIdentifierId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            itemIdentifierId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            var createDateTimeStamp = runtimeEntityType.AddProperty(
                "CreateDateTimeStamp",
                typeof(DateTime?),
                propertyInfo: typeof(ItemIdentifier).GetProperty("CreateDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<CreateDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            createDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            createDateTimeStamp.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            createDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var isDeleted = runtimeEntityType.AddProperty(
                "IsDeleted",
                typeof(bool?),
                propertyInfo: typeof(ItemIdentifier).GetProperty("IsDeleted", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<IsDeleted>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            isDeleted.AddAnnotation("Relational:DefaultValue", false);
            isDeleted.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemGuid = runtimeEntityType.AddProperty(
                "ItemGuid",
                typeof(Guid),
                propertyInfo: typeof(ItemIdentifier).GetProperty("ItemGuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<ItemGuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            itemGuid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemId = runtimeEntityType.AddProperty(
                "ItemId",
                typeof(long),
                propertyInfo: typeof(ItemIdentifier).GetProperty("ItemId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<ItemId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            itemId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemIdentifierDescription = runtimeEntityType.AddProperty(
                "ItemIdentifierDescription",
                typeof(string),
                propertyInfo: typeof(ItemIdentifier).GetProperty("ItemIdentifierDescription", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<ItemIdentifierDescription>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                maxLength: 300);
            itemIdentifierDescription.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemIdentifierDistinctiveMarkingId = runtimeEntityType.AddProperty(
                "ItemIdentifierDistinctiveMarkingId",
                typeof(int?),
                propertyInfo: typeof(ItemIdentifier).GetProperty("ItemIdentifierDistinctiveMarkingId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<ItemIdentifierDistinctiveMarkingId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            itemIdentifierDistinctiveMarkingId.AddAnnotation("Relational:DefaultValue", 1);
            itemIdentifierDistinctiveMarkingId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemIdentifierGuid = runtimeEntityType.AddProperty(
                "ItemIdentifierGuid",
                typeof(Guid),
                propertyInfo: typeof(ItemIdentifier).GetProperty("ItemIdentifierGuid", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<ItemIdentifierGuid>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                valueGenerated: ValueGenerated.OnAdd,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));
            itemIdentifierGuid.AddAnnotation("Relational:DefaultValueSql", "(newid())");
            itemIdentifierGuid.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var itemIdentifierLocationId = runtimeEntityType.AddProperty(
                "ItemIdentifierLocationId",
                typeof(int?),
                propertyInfo: typeof(ItemIdentifier).GetProperty("ItemIdentifierLocationId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<ItemIdentifierLocationId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            itemIdentifierLocationId.AddAnnotation("Relational:DefaultValue", 1);
            itemIdentifierLocationId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var modifiedDateTimeStamp = runtimeEntityType.AddProperty(
                "ModifiedDateTimeStamp",
                typeof(DateTime?),
                propertyInfo: typeof(ItemIdentifier).GetProperty("ModifiedDateTimeStamp", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<ModifiedDateTimeStamp>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            modifiedDateTimeStamp.AddAnnotation("Relational:ColumnType", "datetime");
            modifiedDateTimeStamp.AddAnnotation("Relational:DefaultValueSql", "(getdate())");
            modifiedDateTimeStamp.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var rowStatusId = runtimeEntityType.AddProperty(
                "RowStatusId",
                typeof(int?),
                propertyInfo: typeof(ItemIdentifier).GetProperty("RowStatusId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<RowStatusId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            rowStatusId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var sourceId = runtimeEntityType.AddProperty(
                "SourceId",
                typeof(long),
                propertyInfo: typeof(ItemIdentifier).GetProperty("SourceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<SourceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                sentinel: 0L);
            sourceId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { itemIdentifierId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { itemId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { itemIdentifierDistinctiveMarkingId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { itemIdentifierLocationId });

            var index2 = runtimeEntityType.AddIndex(
                new[] { rowStatusId });

            var index3 = runtimeEntityType.AddIndex(
                new[] { sourceId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ItemId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ItemId") }),
                principalEntityType,
                required: true);

            var item = declaringEntityType.AddNavigation("Item",
                runtimeForeignKey,
                onDependent: true,
                typeof(Item),
                propertyInfo: typeof(ItemIdentifier).GetProperty("Item", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<Item>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var itemIdentifiers = principalEntityType.AddNavigation("ItemIdentifiers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<ItemIdentifier>),
                propertyInfo: typeof(Item).GetProperty("ItemIdentifiers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Item).GetField("<ItemIdentifiers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "Object_ObjectIdentifiers_FK1");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ItemIdentifierDistinctiveMarkingId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ItemIdentifierDistinctiveMarkingId") }),
                principalEntityType);

            var itemIdentifierDistinctiveMarking = declaringEntityType.AddNavigation("ItemIdentifierDistinctiveMarking",
                runtimeForeignKey,
                onDependent: true,
                typeof(ItemIdentifierDistinctiveMarkingDim),
                propertyInfo: typeof(ItemIdentifier).GetProperty("ItemIdentifierDistinctiveMarking", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<ItemIdentifierDistinctiveMarking>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var itemIdentifiers = principalEntityType.AddNavigation("ItemIdentifiers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<ItemIdentifier>),
                propertyInfo: typeof(ItemIdentifierDistinctiveMarkingDim).GetProperty("ItemIdentifiers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifierDistinctiveMarkingDim).GetField("<ItemIdentifiers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_ItemIdentifier_ItemIdentifierDistinctiveMarkingDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("ItemIdentifierLocationId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("ItemIdentifierLocationId") }),
                principalEntityType);

            var itemIdentifierLocation = declaringEntityType.AddNavigation("ItemIdentifierLocation",
                runtimeForeignKey,
                onDependent: true,
                typeof(ItemIdentifierLocationDim),
                propertyInfo: typeof(ItemIdentifier).GetProperty("ItemIdentifierLocation", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<ItemIdentifierLocation>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var itemIdentifiers = principalEntityType.AddNavigation("ItemIdentifiers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<ItemIdentifier>),
                propertyInfo: typeof(ItemIdentifierLocationDim).GetProperty("ItemIdentifiers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifierLocationDim).GetField("<ItemIdentifiers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "itemIdentifierLocaitonDIM_ObjectIdentifiers_FK1");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("RowStatusId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("RowStatusId") }),
                principalEntityType);

            var rowStatus = declaringEntityType.AddNavigation("RowStatus",
                runtimeForeignKey,
                onDependent: true,
                typeof(RowStatusDim),
                propertyInfo: typeof(ItemIdentifier).GetProperty("RowStatus", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<RowStatus>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var itemIdentifiers = principalEntityType.AddNavigation("ItemIdentifiers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<ItemIdentifier>),
                propertyInfo: typeof(RowStatusDim).GetProperty("ItemIdentifiers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(RowStatusDim).GetField("<ItemIdentifiers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_ItemIdentifier_RowStatusDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey5(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("SourceId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("SourceId") }),
                principalEntityType,
                required: true);

            var source = declaringEntityType.AddNavigation("Source",
                runtimeForeignKey,
                onDependent: true,
                typeof(Source),
                propertyInfo: typeof(ItemIdentifier).GetProperty("Source", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(ItemIdentifier).GetField("<Source>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var itemIdentifiers = principalEntityType.AddNavigation("ItemIdentifiers",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<ItemIdentifier>),
                propertyInfo: typeof(Source).GetProperty("ItemIdentifiers", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Source).GetField("<ItemIdentifiers>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_ItemIdentifier_Source");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "ItemIdentifier");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
