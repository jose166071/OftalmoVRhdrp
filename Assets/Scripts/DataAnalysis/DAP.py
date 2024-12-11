from PyVisualFields import visualFields

def RunScript():

	df_VFs_py = visualFields.data_vfpwgRetest24d2()#df_VFs_py is acquired using vfpwgRetest24d2() function.
	vf = df_VFs_py.iloc[[0]]#vf is the first row of df_VFs_py
	visualFields.vfsfa(vf, 'report.pdf')
	return "done"

RunScript()