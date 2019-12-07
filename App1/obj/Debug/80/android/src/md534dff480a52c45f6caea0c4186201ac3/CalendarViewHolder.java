package md534dff480a52c45f6caea0c4186201ac3;


public class CalendarViewHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("App1.CalendarViewHolder, App1", CalendarViewHolder.class, __md_methods);
	}


	public CalendarViewHolder ()
	{
		super ();
		if (getClass () == CalendarViewHolder.class)
			mono.android.TypeManager.Activate ("App1.CalendarViewHolder, App1", "", this, new java.lang.Object[] {  });
	}

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
