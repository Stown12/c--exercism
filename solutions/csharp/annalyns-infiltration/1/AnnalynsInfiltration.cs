static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => knightIsAwake != true;

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => knightIsAwake || archerIsAwake || prisonerIsAwake;

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake) => (archerIsAwake == false) && (prisonerIsAwake == true);

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if(!petDogIsPresent)
        {
            if(prisonerIsAwake && (!knightIsAwake && !archerIsAwake))
            {
                return true;
            }
        } else if(!archerIsAwake)
        {
            return true;
        }
        return false;
    }
}
