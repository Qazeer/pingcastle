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
	[RuleObjectiveAttribute("A-IndirectUser-High-Any", RiskRuleCategory.Anomalies, RiskModelObjective.AnomalyAccessHigh)]
	[RuleComputation(RuleComputationType.Objective, 90)]
	[RuleANSSI("R18", "subsubsection.3.3.2")]
	public class CompromiseGraphAnomalyIndirectUserHighAny : CompromiseGraphAnomalyIndirectUser
	{
		protected override int? AnalyzeDataNew(CompromiseGraphData compromiseGraphData)
		{
			return AnalyzeDataNew(compromiseGraphData, CompromiseGraphDataObjectRisk.High, -1);
		}
	}
}
