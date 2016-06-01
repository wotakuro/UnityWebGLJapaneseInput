var WebNativeDialog = {
   NativeDialogPrompt:function (title , defaultValue){
     var result = window.prompt( Pointer_stringify(title) , Pointer_stringify(defaultValue) );
     var buffer = _malloc(lengthBytesUTF8(result) + 1);
     writeStringToMemory(result, buffer);
     return buffer;
   }
};
mergeInto( LibraryManager.library , WebNativeDialog );

