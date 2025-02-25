using RimWorld;
using TwitchToolkit.Votes;

namespace TwitchToolkit.VotingHelpers.VotingHelpers_Raids;

public class MediumRaid : VotingHelper
{
	private float points;

	private PawnsArrivalModeDef arrival = PawnsArrivalModeDefOf.EdgeWalkIn;

	public override bool IsPossible()
	{
		points = StorytellerUtility.DefaultThreatPointsNow(target) / 2f;
		return RaidHelpers.RaidPossible(points, arrival);
	}

	public override void TryExecute()
	{
		RaidHelpers.Raid(points, arrival);
	}
}
