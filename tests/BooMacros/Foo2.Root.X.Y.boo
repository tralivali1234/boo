namespace BooMacros

import BooSupportingClasses.NestedMacros #for foo2.root

macro foo2.root.x.y:
	yield [| print " y:${$(root.Name)}" |]
	yield
