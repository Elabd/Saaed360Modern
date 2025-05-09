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
    public partial class AlertEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Domain.Entities.Alert",
                typeof(Alert),
                baseEntityType,
                propertyCount: 16,
                navigationCount: 12,
                foreignKeyCount: 12,
                unnamedIndexCount: 11,
                keyCount: 1);

            var activityId = runtimeEntityType.AddProperty(
                "ActivityId",
                typeof(long),
                propertyInfo: typeof(Alert).GetProperty("ActivityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<ActivityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);
            activityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var alertAudienceId = runtimeEntityType.AddProperty(
                "AlertAudienceId",
                typeof(int?),
                propertyInfo: typeof(Alert).GetProperty("AlertAudienceId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertAudienceId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            alertAudienceId.AddAnnotation("Relational:DefaultValue", 1);
            alertAudienceId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var alertCategoryId = runtimeEntityType.AddProperty(
                "AlertCategoryId",
                typeof(int?),
                propertyInfo: typeof(Alert).GetProperty("AlertCategoryId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertCategoryId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            alertCategoryId.AddAnnotation("Relational:DefaultValue", 1);
            alertCategoryId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var alertCertaintyId = runtimeEntityType.AddProperty(
                "AlertCertaintyId",
                typeof(int?),
                propertyInfo: typeof(Alert).GetProperty("AlertCertaintyId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertCertaintyId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            alertCertaintyId.AddAnnotation("Relational:DefaultValue", 1);
            alertCertaintyId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var alertEventId = runtimeEntityType.AddProperty(
                "AlertEventId",
                typeof(int?),
                propertyInfo: typeof(Alert).GetProperty("AlertEventId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertEventId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            alertEventId.AddAnnotation("Relational:DefaultValue", 1);
            alertEventId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var alertHandlingId = runtimeEntityType.AddProperty(
                "AlertHandlingId",
                typeof(int?),
                propertyInfo: typeof(Alert).GetProperty("AlertHandlingId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertHandlingId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            alertHandlingId.AddAnnotation("Relational:DefaultValue", 1);
            alertHandlingId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var alertInstructionId = runtimeEntityType.AddProperty(
                "AlertInstructionId",
                typeof(int?),
                propertyInfo: typeof(Alert).GetProperty("AlertInstructionId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertInstructionId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            alertInstructionId.AddAnnotation("Relational:DefaultValue", 1);
            alertInstructionId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var alertReasonId = runtimeEntityType.AddProperty(
                "AlertReasonId",
                typeof(int?),
                propertyInfo: typeof(Alert).GetProperty("AlertReasonId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertReasonId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            alertReasonId.AddAnnotation("Relational:DefaultValue", 1);
            alertReasonId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var alertSenderId = runtimeEntityType.AddProperty(
                "AlertSenderId",
                typeof(int?),
                propertyInfo: typeof(Alert).GetProperty("AlertSenderId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertSenderId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            alertSenderId.AddAnnotation("Relational:DefaultValue", 1);
            alertSenderId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var alertSeverityId = runtimeEntityType.AddProperty(
                "AlertSeverityId",
                typeof(int?),
                propertyInfo: typeof(Alert).GetProperty("AlertSeverityId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertSeverityId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            alertSeverityId.AddAnnotation("Relational:DefaultValue", 1);
            alertSeverityId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var alertTargetId = runtimeEntityType.AddProperty(
                "AlertTargetId",
                typeof(int?),
                propertyInfo: typeof(Alert).GetProperty("AlertTargetId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertTargetId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            alertTargetId.AddAnnotation("Relational:DefaultValue", 1);
            alertTargetId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var alertUrgencyId = runtimeEntityType.AddProperty(
                "AlertUrgencyId",
                typeof(int?),
                propertyInfo: typeof(Alert).GetProperty("AlertUrgencyId", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertUrgencyId>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                valueGenerated: ValueGenerated.OnAdd);
            alertUrgencyId.AddAnnotation("Relational:DefaultValue", 1);
            alertUrgencyId.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var effectiveDate = runtimeEntityType.AddProperty(
                "EffectiveDate",
                typeof(DateTime?),
                propertyInfo: typeof(Alert).GetProperty("EffectiveDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<EffectiveDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            effectiveDate.AddAnnotation("Relational:ColumnType", "datetime");
            effectiveDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var expirationDate = runtimeEntityType.AddProperty(
                "ExpirationDate",
                typeof(DateTime?),
                propertyInfo: typeof(Alert).GetProperty("ExpirationDate", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<ExpirationDate>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            expirationDate.AddAnnotation("Relational:ColumnType", "datetime");
            expirationDate.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var headline = runtimeEntityType.AddProperty(
                "Headline",
                typeof(string),
                propertyInfo: typeof(Alert).GetProperty("Headline", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<Headline>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true,
                maxLength: 200);
            headline.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var message = runtimeEntityType.AddProperty(
                "Message",
                typeof(string),
                propertyInfo: typeof(Alert).GetProperty("Message", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<Message>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);
            message.AddAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.None);

            var key = runtimeEntityType.AddKey(
                new[] { activityId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { alertAudienceId });

            var index0 = runtimeEntityType.AddIndex(
                new[] { alertCategoryId });

            var index1 = runtimeEntityType.AddIndex(
                new[] { alertCertaintyId });

            var index2 = runtimeEntityType.AddIndex(
                new[] { alertEventId });

            var index3 = runtimeEntityType.AddIndex(
                new[] { alertHandlingId });

            var index4 = runtimeEntityType.AddIndex(
                new[] { alertInstructionId });

            var index5 = runtimeEntityType.AddIndex(
                new[] { alertReasonId });

            var index6 = runtimeEntityType.AddIndex(
                new[] { alertSenderId });

            var index7 = runtimeEntityType.AddIndex(
                new[] { alertSeverityId });

            var index8 = runtimeEntityType.AddIndex(
                new[] { alertTargetId });

            var index9 = runtimeEntityType.AddIndex(
                new[] { alertUrgencyId });

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
                propertyInfo: typeof(Alert).GetProperty("Activity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<Activity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var alert = principalEntityType.AddNavigation("Alert",
                runtimeForeignKey,
                onDependent: false,
                typeof(Alert),
                propertyInfo: typeof(Activity).GetProperty("Alert", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Activity).GetField("<Alert>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Alert_Activity");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AlertAudienceId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AlertAudienceId") }),
                principalEntityType);

            var alertAudience = declaringEntityType.AddNavigation("AlertAudience",
                runtimeForeignKey,
                onDependent: true,
                typeof(AlertAudienceDim),
                propertyInfo: typeof(Alert).GetProperty("AlertAudience", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertAudience>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var alerts = principalEntityType.AddNavigation("Alerts",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Alert>),
                propertyInfo: typeof(AlertAudienceDim).GetProperty("Alerts", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AlertAudienceDim).GetField("<Alerts>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "AlertAudienceDIM_Alert_FK1");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey3(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AlertCategoryId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AlertCategoryId") }),
                principalEntityType);

            var alertCategory = declaringEntityType.AddNavigation("AlertCategory",
                runtimeForeignKey,
                onDependent: true,
                typeof(AlertCategoryDim),
                propertyInfo: typeof(Alert).GetProperty("AlertCategory", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertCategory>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var alerts = principalEntityType.AddNavigation("Alerts",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Alert>),
                propertyInfo: typeof(AlertCategoryDim).GetProperty("Alerts", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AlertCategoryDim).GetField("<Alerts>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Alert_AlertCategoryDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey4(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AlertCertaintyId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AlertCertaintyId") }),
                principalEntityType);

            var alertCertainty = declaringEntityType.AddNavigation("AlertCertainty",
                runtimeForeignKey,
                onDependent: true,
                typeof(AlertCertaintyDim),
                propertyInfo: typeof(Alert).GetProperty("AlertCertainty", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertCertainty>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var alerts = principalEntityType.AddNavigation("Alerts",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Alert>),
                propertyInfo: typeof(AlertCertaintyDim).GetProperty("Alerts", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AlertCertaintyDim).GetField("<Alerts>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "AlertCertantyDIM_Alert_FK1");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey5(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AlertEventId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AlertEventId") }),
                principalEntityType);

            var alertEvent = declaringEntityType.AddNavigation("AlertEvent",
                runtimeForeignKey,
                onDependent: true,
                typeof(AlertEventDim),
                propertyInfo: typeof(Alert).GetProperty("AlertEvent", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertEvent>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var alerts = principalEntityType.AddNavigation("Alerts",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Alert>),
                propertyInfo: typeof(AlertEventDim).GetProperty("Alerts", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AlertEventDim).GetField("<Alerts>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "AlertEventDIM_Alert_FK1");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey6(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AlertHandlingId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AlertHandlingId") }),
                principalEntityType);

            var alertHandling = declaringEntityType.AddNavigation("AlertHandling",
                runtimeForeignKey,
                onDependent: true,
                typeof(AlertHandlingDim),
                propertyInfo: typeof(Alert).GetProperty("AlertHandling", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertHandling>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var alerts = principalEntityType.AddNavigation("Alerts",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Alert>),
                propertyInfo: typeof(AlertHandlingDim).GetProperty("Alerts", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AlertHandlingDim).GetField("<Alerts>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Alert_AlertHandlingDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey7(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AlertInstructionId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AlertInstructionId") }),
                principalEntityType);

            var alertInstruction = declaringEntityType.AddNavigation("AlertInstruction",
                runtimeForeignKey,
                onDependent: true,
                typeof(AlertInstructionDim),
                propertyInfo: typeof(Alert).GetProperty("AlertInstruction", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertInstruction>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var alerts = principalEntityType.AddNavigation("Alerts",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Alert>),
                propertyInfo: typeof(AlertInstructionDim).GetProperty("Alerts", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AlertInstructionDim).GetField("<Alerts>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "AlertInstructionDIM_Alert_FK1");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey8(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AlertReasonId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AlertReasonId") }),
                principalEntityType);

            var alertReason = declaringEntityType.AddNavigation("AlertReason",
                runtimeForeignKey,
                onDependent: true,
                typeof(AlertReasonDim),
                propertyInfo: typeof(Alert).GetProperty("AlertReason", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertReason>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var alerts = principalEntityType.AddNavigation("Alerts",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Alert>),
                propertyInfo: typeof(AlertReasonDim).GetProperty("Alerts", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AlertReasonDim).GetField("<Alerts>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "FK_Alert_AlertReasonDIM");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey9(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AlertSenderId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AlertSenderId") }),
                principalEntityType);

            var alertSender = declaringEntityType.AddNavigation("AlertSender",
                runtimeForeignKey,
                onDependent: true,
                typeof(AlertSenderDim),
                propertyInfo: typeof(Alert).GetProperty("AlertSender", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertSender>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var alerts = principalEntityType.AddNavigation("Alerts",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Alert>),
                propertyInfo: typeof(AlertSenderDim).GetProperty("Alerts", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AlertSenderDim).GetField("<Alerts>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "AlertSenderDIM_Alert_FK1");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey10(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AlertSeverityId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AlertSeverityId") }),
                principalEntityType);

            var alertSeverity = declaringEntityType.AddNavigation("AlertSeverity",
                runtimeForeignKey,
                onDependent: true,
                typeof(AlertSeverityDim),
                propertyInfo: typeof(Alert).GetProperty("AlertSeverity", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertSeverity>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var alerts = principalEntityType.AddNavigation("Alerts",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Alert>),
                propertyInfo: typeof(AlertSeverityDim).GetProperty("Alerts", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AlertSeverityDim).GetField("<Alerts>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "AlertSeverityDIM_Alert_FK1");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey11(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AlertTargetId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AlertTargetId") }),
                principalEntityType);

            var alertTarget = declaringEntityType.AddNavigation("AlertTarget",
                runtimeForeignKey,
                onDependent: true,
                typeof(AlertTargetDim),
                propertyInfo: typeof(Alert).GetProperty("AlertTarget", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertTarget>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var alerts = principalEntityType.AddNavigation("Alerts",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Alert>),
                propertyInfo: typeof(AlertTargetDim).GetProperty("Alerts", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AlertTargetDim).GetField("<Alerts>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "AlertTargetDIM_Alert_FK1");
            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey12(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("AlertUrgencyId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("AlertUrgencyId") }),
                principalEntityType);

            var alertUrgency = declaringEntityType.AddNavigation("AlertUrgency",
                runtimeForeignKey,
                onDependent: true,
                typeof(AlertUrgencyDim),
                propertyInfo: typeof(Alert).GetProperty("AlertUrgency", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(Alert).GetField("<AlertUrgency>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var alerts = principalEntityType.AddNavigation("Alerts",
                runtimeForeignKey,
                onDependent: false,
                typeof(ICollection<Alert>),
                propertyInfo: typeof(AlertUrgencyDim).GetProperty("Alerts", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(AlertUrgencyDim).GetField("<Alerts>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            runtimeForeignKey.AddAnnotation("Relational:Name", "AlertUrgencyDIM_Alert_FK1");
            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "Alert");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
