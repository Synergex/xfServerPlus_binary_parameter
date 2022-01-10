# xfServerPlus_binary_parameter<br />
**Created Date:** 6/15/2005<br />
**Last Updated:** 5/21/2008<br />
**Description:** An example of using Synergy/DE 8.3's new "binary parameters". Included are utility routines to load a file's binary data into a memory handle, and save a memory handle to a file, as well as example Synergy methods which allow files to be both uploaded to a server, and downloaded from a server. Also included is example VB.NET code showing how to save a files binary data (retrieved via a Synergy method call) to a local file on the client system.<br />
**Platforms:** Windows; Unix; OpenVMS<br />
**Products:** xfServerPlus; VB .NET<br />
**Minimum Version:** 8.1<br />
**Author:** Steve Ives
<hr>

**Additional Information:**
Version: 8.3 for use with xfServerPlus binary parameters
8.1 for general use in loading and unloading file data to and
from memory handles.

file_to_handle.dbl
------------------
This routine accepts a file name and a memory handle, and load the content of
the file (in binary mode) into the memory handle. The memory handle must have
been pre-allocated to any size (for example 1-byte) before calling the routine.
On return, the memory handle will have been resized to the exact size of the
file.

handle_to_file.dbl
------------------
This routine accepts a memory handle containing the data from a file (loaded in
binary mode) and a file name. The data from the menory handle is then saved to
the specified file. It is the responsibility of the calling routine to free
the synamic memory.

test.dbl
--------
This program tests the functionality of the file_to_handle and handle_to_file
routines. It loads the supplied spc2005.jpg file into a memory handle, then
unloads the binary data into a new file called spc2005_new.jpg.

test.bat
--------
This Windows batch file compiles, links and executes the test.dbl program

download_file.dbl
-----------------
This is an example of a Synergy method which allows a named file to be
downloaded to a client via xfServerPlus.

upload_file.dbl
---------------
This is an example of a Synergy method which allows a named file to be uploaded
to a server via xfServerPlus.

get_logo.dbl
------------
This is an axample of a Synergy method which downloads a pre-determined file to
a client via xfServerPlus.

BinaryToFile.vb
---------------
This is a VB.NET example of how you might save the binary data of a file (from
an xfServerPlus binary parameter) to a local file. It could be used after
making a call to download_file.

FileToBinary.vb
---------------
This is a VB.NET example of how you might load the content of a file into a byte
array (for sending to the server via an xfServerPlus binary parameter). It
could be used before making a call to upload_file.
