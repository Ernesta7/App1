package md534dff480a52c45f6caea0c4186201ac3;


public class LifeNoteItem
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_toString:()Ljava/lang/String;:GetToStringHandler\n" +
			"";
		mono.android.Runtime.register ("App1.LifeNoteItem, App1", LifeNoteItem.class, __md_methods);
	}


	public LifeNoteItem ()
	{
		super ();
		if (getClass () == LifeNoteItem.class)
			mono.android.TypeManager.Activate ("App1.LifeNoteItem, App1", "", this, new java.lang.Object[] {  });
	}


	public java.lang.String toString ()
	{
		return n_toString ();
	}

	private native java.lang.String n_toString ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
