from PyVisualFields import visualFields
import pandas as pd
from datetime import datetime
import rpy2
def RunScript():

	df_VFs_py = pd.read_csv("C:\\Users\\biomedica\\Documents\\Jose Rosales\\OftalmoVR\\Assets\\CSV\\resultTest.csv")
	#df_VFs_py = visualFields.data_vfpwgRetest24d2()#df_VFs_py is acquired using vfpwgRetest24d2() function.
	vf = df_VFs_py.iloc[[0]]#vf is the first row of df_VFs_py
	fileName = "Report"+str(vf["date"][0])+".pdf"
	vf["date"] = datetime.today().strftime('%Y-%m-%d')
	vf['date'] = pd.to_datetime(vf['date'])
	
	visualFields.vfsfa(vf, fileName)
	return "done"

RunScript()