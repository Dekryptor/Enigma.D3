public class MonsterChampionSpawnItem : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x08; // 8

	public MonsterChampionSpawnItem(ProcessMemory memory, int address)
		: base(memory, address) { }

	public int x00_ActorSnoId { get { return Field<int>(0x00); } }
	public int x04 { get { return Field<int>(0x04); } }
}