// Copyright (c) 2020 by Meinrad Recheis (Member of SciSharp)
// Code generated by CodeMinion: https://github.com/SciSharp/CodeMinion

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using Python.Runtime;
using Numpy.Models;
#if PYTHON_INCLUDED
using Python.Included;
#endif

namespace Numpy
{
    public static partial class np
    {
        
        /// <summary>
        ///	Pads an array.<br></br>
        ///	
        ///	Notes
        ///	
        ///	For an array with rank greater than 1, some of the padding of later
        ///	axes is calculated from padding of previous axes.<br></br>
        ///	  This is easiest to
        ///	think about with a rank 2 array where the corners of the padded array
        ///	are calculated by using padded values from the first axis.<br></br>
        ///	
        ///	The padding function, if used, should return a rank 1 array equal in
        ///	length to the vector argument with padded values replaced.<br></br>
        ///	 It has the
        ///	following signature:
        ///	
        ///	where
        /// </summary>
        /// <param name="array">
        ///	Input array
        /// </param>
        /// <param name="pad_width">
        ///	Number of values padded to the edges of each axis.<br></br>
        ///	
        ///	((before_1, after_1), … (before_N, after_N)) unique pad widths
        ///	for each axis.<br></br>
        ///	
        ///	((before, after),) yields same before and after pad for each axis.<br></br>
        ///	
        ///	(pad,) or int is a shortcut for before = after = pad width for all
        ///	axes.
        /// </param>
        /// <param name="mode">
        ///	One of the following string values or a user supplied function.
        /// </param>
        /// <param name="stat_length">
        ///	Used in ‘maximum’, ‘mean’, ‘median’, and ‘minimum’.  Number of
        ///	values at edge of each axis used to calculate the statistic value.<br></br>
        ///	
        ///	((before_1, after_1), … (before_N, after_N)) unique statistic
        ///	lengths for each axis.<br></br>
        ///	
        ///	((before, after),) yields same before and after statistic lengths
        ///	for each axis.<br></br>
        ///	
        ///	(stat_length,) or int is a shortcut for before = after = statistic
        ///	length for all axes.<br></br>
        ///	
        ///	Default is None, to use the entire axis.
        /// </param>
        /// <param name="constant_values">
        ///	Used in ‘constant’.  The values to set the padded values for each
        ///	axis.<br></br>
        ///	
        ///	((before_1, after_1), … (before_N, after_N)) unique pad constants
        ///	for each axis.<br></br>
        ///	
        ///	((before, after),) yields same before and after constants for each
        ///	axis.<br></br>
        ///	
        ///	(constant,) or int is a shortcut for before = after = constant for
        ///	all axes.<br></br>
        ///	
        ///	Default is 0.
        /// </param>
        /// <param name="end_values">
        ///	Used in ‘linear_ramp’.  The values used for the ending value of the
        ///	linear_ramp and that will form the edge of the padded array.<br></br>
        ///	
        ///	((before_1, after_1), … (before_N, after_N)) unique end values
        ///	for each axis.<br></br>
        ///	
        ///	((before, after),) yields same before and after end values for each
        ///	axis.<br></br>
        ///	
        ///	(constant,) or int is a shortcut for before = after = end value for
        ///	all axes.<br></br>
        ///	
        ///	Default is 0.
        /// </param>
        /// <param name="reflect_type">
        ///	Used in ‘reflect’, and ‘symmetric’.  The ‘even’ style is the
        ///	default with an unaltered reflection around the edge value.<br></br>
        ///	For
        ///	the ‘odd’ style, the extended part of the array is created by
        ///	subtracting the reflected values from two times the edge value.
        /// </param>
        /// <returns>
        ///	Padded array of rank equal to array with shape increased
        ///	according to pad_width.
        /// </returns>
        public static NDarray pad(NDarray array, NDarray pad_width, string mode, int[] stat_length = null, int[] constant_values = null, int[] end_values = null, string reflect_type = null)
        {
            //auto-generated code, do not change
            var __self__=self;
            var pyargs=ToTuple(new object[]
            {
                array,
                pad_width,
                mode,
            });
            var kwargs=new PyDict();
            if (stat_length!=null) kwargs["stat_length"]=ToPython(stat_length);
            if (constant_values!=null) kwargs["constant_values"]=ToPython(constant_values);
            if (end_values!=null) kwargs["end_values"]=ToPython(end_values);
            if (reflect_type!=null) kwargs["reflect_type"]=ToPython(reflect_type);
            dynamic py = __self__.InvokeMethod("pad", pyargs, kwargs);
            return ToCsharp<NDarray>(py);
        }
        
        
    }
}
