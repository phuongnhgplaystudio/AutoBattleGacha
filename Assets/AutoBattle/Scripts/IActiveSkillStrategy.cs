namespace AutoBattle
{
    public interface IActiveSkillStrategy
    {
        public SkillResult DOActiveSkill(BattleController battleController);
    }
}
