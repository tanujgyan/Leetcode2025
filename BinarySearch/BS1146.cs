namespace BinarySearch;

public class SnapshotArray {

    public int[] Snapshots;
    public Dictionary<int, int[]> Dictionary = new();
    public int SnapId = 0;
    public SnapshotArray(int length) {
        Snapshots = new int[length];
        for(int i=0;i<length;i++)
        {
            Snapshots[i] = 0;
        }
    }
    
    public void Set(int index, int val) {
        Snapshots[index] = val;
    }
    
    public int Snap()
    {
        var arr = new int[Snapshots.Length];
        Snapshots.CopyTo(arr,0);
        Dictionary.Add(SnapId, arr);
        SnapId++;
        return SnapId-1;
    }
    
    public int Get(int index, int snap_id) {
        if(Dictionary.ContainsKey(snap_id))
        {
            var d = Dictionary[snap_id];
            return d[index];
        }

        return -1;
    }
}