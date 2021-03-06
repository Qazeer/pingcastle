﻿//
// Copyright (c) Ping Castle. All rights reserved.
// https://www.pingcastle.com
//
// Licensed under the Non-Profit OSL. See LICENSE file in the project root for full license information.
//
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using PingCastle.Rules;
using PingCastle.Data;

namespace PingCastle.Graph.Rules
{
	[RuleObjectiveAttribute("A-IndirectUser-High-10", RiskRuleCategory.Anomalies, RiskModelObjective.AnomalyAccessHigh)]
	[RuleComputation(RuleComputationType.Objective, 60)]
	public class CompromiseGraphAnomalyIndirectUserHigh10 : CompromiseGraphAnomalyIndirectUser
	{
		protected override int? AnalyzeDataNew(CompromiseGraphData compromiseGraphData)
		{
			return AnalyzeDataNew(compromiseGraphData, CompromiseGraphDataObjectRisk.High, 10);
		}
	}
}
