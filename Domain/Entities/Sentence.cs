using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Sentence
{
    public long ActivityId { get; set; }

    public bool SentenceAggravatedIndicator { get; set; }

    public int SentenceConfinementCreditDayQuantity { get; set; }

    public bool SentenceConfinementCreditIndicator { get; set; }

    public bool SentenceDeferredIndicator { get; set; }

    public DateOnly? SentenceDeferredTermMinDuration { get; set; }

    public DateOnly? SentenceDeferredTermMaxDuration { get; set; }

    public int SentenceGroupingId { get; set; }

    public DateOnly? SentenceTermMinDuration { get; set; }

    public DateOnly? SentenceTermMaxDuration { get; set; }

    public bool SentenceRegisterSexOffenderIndicator { get; set; }

    public bool SentenceSuspendedIndicator { get; set; }

    public DateOnly? SentenceSuspendedTermMinDuration { get; set; }

    public DateOnly? SentenceSuspendedTermMaxDuration { get; set; }

    public virtual Activity Activity { get; set; } = null!;

    public virtual SentenceGroupingDim SentenceGrouping { get; set; } = null!;
}
