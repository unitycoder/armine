//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.0
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Assimp {

public class assimp_swig {
  public static float ai_epsilon {
    get {
      float ret = assimp_swigPINVOKE.ai_epsilon_get();
      return ret;
    } 
  }

  public static string aiGetLegalString() {
    string ret = assimp_swigPINVOKE.aiGetLegalString();
    return ret;
  }

  public static uint aiGetVersionMinor() {
    uint ret = assimp_swigPINVOKE.aiGetVersionMinor();
    return ret;
  }

  public static uint aiGetVersionMajor() {
    uint ret = assimp_swigPINVOKE.aiGetVersionMajor();
    return ret;
  }

  public static uint aiGetVersionRevision() {
    uint ret = assimp_swigPINVOKE.aiGetVersionRevision();
    return ret;
  }

  public static string aiGetBranchName() {
    string ret = assimp_swigPINVOKE.aiGetBranchName();
    return ret;
  }

  public static uint aiGetCompileFlags() {
    uint ret = assimp_swigPINVOKE.aiGetCompileFlags();
    return ret;
  }

  public static uint MAXLEN {
    get {
      uint ret = assimp_swigPINVOKE.MAXLEN_get();
      return ret;
    } 
  }

  public static aiReturn aiGetMaterialUVTransform(aiMaterial pMat, string pKey, uint type, uint index, aiUVTransform pOut) {
    aiReturn ret = (aiReturn)assimp_swigPINVOKE.aiGetMaterialUVTransform(aiMaterial.getCPtr(pMat), pKey, type, index, aiUVTransform.getCPtr(pOut));
    return ret;
  }

  public static aiMetadataType GetAiType(bool arg0) {
    aiMetadataType ret = (aiMetadataType)assimp_swigPINVOKE.GetAiType__SWIG_0(arg0);
    return ret;
  }

  public static aiMetadataType GetAiType(int arg0) {
    aiMetadataType ret = (aiMetadataType)assimp_swigPINVOKE.GetAiType__SWIG_1(arg0);
    return ret;
  }

  public static aiMetadataType GetAiType(ulong arg0) {
    aiMetadataType ret = (aiMetadataType)assimp_swigPINVOKE.GetAiType__SWIG_2(arg0);
    return ret;
  }

  public static aiMetadataType GetAiType(float arg0) {
    aiMetadataType ret = (aiMetadataType)assimp_swigPINVOKE.GetAiType__SWIG_3(arg0);
    return ret;
  }

  public static aiMetadataType GetAiType(double arg0) {
    aiMetadataType ret = (aiMetadataType)assimp_swigPINVOKE.GetAiType__SWIG_4(arg0);
    return ret;
  }

  public static aiMetadataType GetAiType(aiString arg0) {
    aiMetadataType ret = (aiMetadataType)assimp_swigPINVOKE.GetAiType__SWIG_5(aiString.getCPtr(arg0));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static aiMetadataType GetAiType(aiVector3D arg0) {
    aiMetadataType ret = (aiMetadataType)assimp_swigPINVOKE.GetAiType__SWIG_6(aiVector3D.getCPtr(arg0));
    if (assimp_swigPINVOKE.SWIGPendingException.Pending) throw assimp_swigPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static aiScene aiImportFile(string pFile, aiPostProcessSteps pFlags) {
    global::System.IntPtr cPtr = assimp_swigPINVOKE.aiImportFile(pFile, (uint)pFlags);
    aiScene ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiScene(cPtr, false);
    return ret;
  }

  public static aiScene aiImportFileEx(string pFile, aiPostProcessSteps pFlags, aiFileIO pFS) {
    global::System.IntPtr cPtr = assimp_swigPINVOKE.aiImportFileEx(pFile, (uint)pFlags, aiFileIO.getCPtr(pFS));
    aiScene ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiScene(cPtr, false);
    return ret;
  }

  public static aiScene aiImportFileExWithProperties(string pFile, aiPostProcessSteps pFlags, aiFileIO pFS, aiPropertyStore pProps) {
    global::System.IntPtr cPtr = assimp_swigPINVOKE.aiImportFileExWithProperties(pFile, (uint)pFlags, aiFileIO.getCPtr(pFS), aiPropertyStore.getCPtr(pProps));
    aiScene ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiScene(cPtr, false);
    return ret;
  }

  public static aiScene aiImportFileFromMemory(string pBuffer, uint pLength, aiPostProcessSteps pFlags, string pHint) {
    global::System.IntPtr cPtr = assimp_swigPINVOKE.aiImportFileFromMemory(pBuffer, pLength, (uint)pFlags, pHint);
    aiScene ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiScene(cPtr, false);
    return ret;
  }

  public static aiScene aiImportFileFromMemoryWithProperties(string pBuffer, uint pLength, aiPostProcessSteps pFlags, string pHint, aiPropertyStore pProps) {
    global::System.IntPtr cPtr = assimp_swigPINVOKE.aiImportFileFromMemoryWithProperties(pBuffer, pLength, (uint)pFlags, pHint, aiPropertyStore.getCPtr(pProps));
    aiScene ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiScene(cPtr, false);
    return ret;
  }

  public static aiScene aiApplyPostProcessing(aiScene pScene, aiPostProcessSteps pFlags) {
    global::System.IntPtr cPtr = assimp_swigPINVOKE.aiApplyPostProcessing(aiScene.getCPtr(pScene), (uint)pFlags);
    aiScene ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiScene(cPtr, false);
    return ret;
  }

  public static aiLogStream aiGetPredefinedLogStream(aiDefaultLogStream pStreams, string file) {
    aiLogStream ret = new aiLogStream(assimp_swigPINVOKE.aiGetPredefinedLogStream((int)pStreams, file), true);
    return ret;
  }

  public static void aiAttachLogStream(aiLogStream stream) {
    assimp_swigPINVOKE.aiAttachLogStream(aiLogStream.getCPtr(stream));
  }

  public static void aiEnableVerboseLogging(int d) {
    assimp_swigPINVOKE.aiEnableVerboseLogging(d);
  }

  public static aiReturn aiDetachLogStream(aiLogStream stream) {
    aiReturn ret = (aiReturn)assimp_swigPINVOKE.aiDetachLogStream(aiLogStream.getCPtr(stream));
    return ret;
  }

  public static void aiDetachAllLogStreams() {
    assimp_swigPINVOKE.aiDetachAllLogStreams();
  }

  public static void aiReleaseImport(aiScene pScene) {
    assimp_swigPINVOKE.aiReleaseImport(aiScene.getCPtr(pScene));
  }

  public static string aiGetErrorString() {
    string ret = assimp_swigPINVOKE.aiGetErrorString();
    return ret;
  }

  public static int aiIsExtensionSupported(string szExtension) {
    int ret = assimp_swigPINVOKE.aiIsExtensionSupported(szExtension);
    return ret;
  }

  public static void aiGetExtensionList(aiString szOut) {
    assimp_swigPINVOKE.aiGetExtensionList(aiString.getCPtr(szOut));
  }

  public static void aiGetMemoryRequirements(aiScene pIn, aiMemoryInfo in_) {
    assimp_swigPINVOKE.aiGetMemoryRequirements(aiScene.getCPtr(pIn), aiMemoryInfo.getCPtr(in_));
  }

  public static aiPropertyStore aiCreatePropertyStore() {
    global::System.IntPtr cPtr = assimp_swigPINVOKE.aiCreatePropertyStore();
    aiPropertyStore ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiPropertyStore(cPtr, false);
    return ret;
  }

  public static void aiReleasePropertyStore(aiPropertyStore p) {
    assimp_swigPINVOKE.aiReleasePropertyStore(aiPropertyStore.getCPtr(p));
  }

  public static void aiSetImportPropertyInteger(aiPropertyStore store, string szName, int value) {
    assimp_swigPINVOKE.aiSetImportPropertyInteger(aiPropertyStore.getCPtr(store), szName, value);
  }

  public static void aiSetImportPropertyFloat(aiPropertyStore store, string szName, float value) {
    assimp_swigPINVOKE.aiSetImportPropertyFloat(aiPropertyStore.getCPtr(store), szName, value);
  }

  public static void aiSetImportPropertyString(aiPropertyStore store, string szName, aiString st) {
    assimp_swigPINVOKE.aiSetImportPropertyString(aiPropertyStore.getCPtr(store), szName, aiString.getCPtr(st));
  }

  public static void aiSetImportPropertyMatrix(aiPropertyStore store, string szName, aiMatrix4x4 mat) {
    assimp_swigPINVOKE.aiSetImportPropertyMatrix(aiPropertyStore.getCPtr(store), szName, aiMatrix4x4.getCPtr(mat));
  }

  public static void aiCreateQuaternionFromMatrix(aiQuaternion quat, aiMatrix3x3 mat) {
    assimp_swigPINVOKE.aiCreateQuaternionFromMatrix(aiQuaternion.getCPtr(quat), aiMatrix3x3.getCPtr(mat));
  }

  public static void aiDecomposeMatrix(aiMatrix4x4 mat, aiVector3D scaling, aiQuaternion rotation, aiVector3D position) {
    assimp_swigPINVOKE.aiDecomposeMatrix(aiMatrix4x4.getCPtr(mat), aiVector3D.getCPtr(scaling), aiQuaternion.getCPtr(rotation), aiVector3D.getCPtr(position));
  }

  public static void aiTransposeMatrix4(aiMatrix4x4 mat) {
    assimp_swigPINVOKE.aiTransposeMatrix4(aiMatrix4x4.getCPtr(mat));
  }

  public static void aiTransposeMatrix3(aiMatrix3x3 mat) {
    assimp_swigPINVOKE.aiTransposeMatrix3(aiMatrix3x3.getCPtr(mat));
  }

  public static void aiTransformVecByMatrix3(aiVector3D vec, aiMatrix3x3 mat) {
    assimp_swigPINVOKE.aiTransformVecByMatrix3(aiVector3D.getCPtr(vec), aiMatrix3x3.getCPtr(mat));
  }

  public static void aiTransformVecByMatrix4(aiVector3D vec, aiMatrix4x4 mat) {
    assimp_swigPINVOKE.aiTransformVecByMatrix4(aiVector3D.getCPtr(vec), aiMatrix4x4.getCPtr(mat));
  }

  public static void aiMultiplyMatrix4(aiMatrix4x4 dst, aiMatrix4x4 src) {
    assimp_swigPINVOKE.aiMultiplyMatrix4(aiMatrix4x4.getCPtr(dst), aiMatrix4x4.getCPtr(src));
  }

  public static void aiMultiplyMatrix3(aiMatrix3x3 dst, aiMatrix3x3 src) {
    assimp_swigPINVOKE.aiMultiplyMatrix3(aiMatrix3x3.getCPtr(dst), aiMatrix3x3.getCPtr(src));
  }

  public static void aiIdentityMatrix3(aiMatrix3x3 mat) {
    assimp_swigPINVOKE.aiIdentityMatrix3(aiMatrix3x3.getCPtr(mat));
  }

  public static void aiIdentityMatrix4(aiMatrix4x4 mat) {
    assimp_swigPINVOKE.aiIdentityMatrix4(aiMatrix4x4.getCPtr(mat));
  }

  public static uint aiGetImportFormatCount() {
    uint ret = assimp_swigPINVOKE.aiGetImportFormatCount();
    return ret;
  }

  public static aiImporterDesc aiGetImportFormatDescription(uint pIndex) {
    global::System.IntPtr cPtr = assimp_swigPINVOKE.aiGetImportFormatDescription(pIndex);
    aiImporterDesc ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiImporterDesc(cPtr, false);
    return ret;
  }

  public static aiImporterDesc aiGetImporterDesc(string extension) {
    global::System.IntPtr cPtr = assimp_swigPINVOKE.aiGetImporterDesc(extension);
    aiImporterDesc ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiImporterDesc(cPtr, false);
    return ret;
  }

  public static uint aiGetExportFormatCount() {
    uint ret = assimp_swigPINVOKE.aiGetExportFormatCount();
    return ret;
  }

  public static aiExportFormatDesc aiGetExportFormatDescription(uint pIndex) {
    global::System.IntPtr cPtr = assimp_swigPINVOKE.aiGetExportFormatDescription(pIndex);
    aiExportFormatDesc ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiExportFormatDesc(cPtr, false);
    return ret;
  }

  public static void aiReleaseExportFormatDescription(aiExportFormatDesc desc) {
    assimp_swigPINVOKE.aiReleaseExportFormatDescription(aiExportFormatDesc.getCPtr(desc));
  }

  public static void aiFreeScene(aiScene pIn) {
    assimp_swigPINVOKE.aiFreeScene(aiScene.getCPtr(pIn));
  }

  public static aiReturn aiExportScene(aiScene pScene, string pFormatId, string pFileName, aiPostProcessSteps pPreprocessing) {
    aiReturn ret = (aiReturn)assimp_swigPINVOKE.aiExportScene(aiScene.getCPtr(pScene), pFormatId, pFileName, (uint)pPreprocessing);
    return ret;
  }

  public static aiReturn aiExportSceneEx(aiScene pScene, string pFormatId, string pFileName, aiFileIO pIO, aiPostProcessSteps pPreprocessing) {
    aiReturn ret = (aiReturn)assimp_swigPINVOKE.aiExportSceneEx(aiScene.getCPtr(pScene), pFormatId, pFileName, aiFileIO.getCPtr(pIO), (uint)pPreprocessing);
    return ret;
  }

  public static aiExportDataBlob aiExportSceneToBlob(aiScene pScene, string pFormatId, aiPostProcessSteps pPreprocessing) {
    global::System.IntPtr cPtr = assimp_swigPINVOKE.aiExportSceneToBlob(aiScene.getCPtr(pScene), pFormatId, (uint)pPreprocessing);
    aiExportDataBlob ret = (cPtr == global::System.IntPtr.Zero) ? null : new aiExportDataBlob(cPtr, false);
    return ret;
  }

  public static void aiReleaseExportBlob(aiExportDataBlob pData) {
    assimp_swigPINVOKE.aiReleaseExportBlob(aiExportDataBlob.getCPtr(pData));
  }

  public static readonly int ASSIMP_AI_REAL_TEXT_PRECISION = assimp_swigPINVOKE.ASSIMP_AI_REAL_TEXT_PRECISION_get();
  public static readonly double AI_MATH_PI = assimp_swigPINVOKE.AI_MATH_PI_get();
  public static readonly double AI_MATH_TWO_PI = assimp_swigPINVOKE.AI_MATH_TWO_PI_get();
  public static readonly double AI_MATH_HALF_PI = assimp_swigPINVOKE.AI_MATH_HALF_PI_get();
  public static readonly double AI_MATH_PI_F = assimp_swigPINVOKE.AI_MATH_PI_F_get();
  public static readonly double AI_MATH_TWO_PI_F = assimp_swigPINVOKE.AI_MATH_TWO_PI_F_get();
  public static readonly double AI_MATH_HALF_PI_F = assimp_swigPINVOKE.AI_MATH_HALF_PI_F_get();
  public static readonly string AI_CONFIG_GLOB_MEASURE_TIME = assimp_swigPINVOKE.AI_CONFIG_GLOB_MEASURE_TIME_get();
  public static readonly string AI_CONFIG_IMPORT_NO_SKELETON_MESHES = assimp_swigPINVOKE.AI_CONFIG_IMPORT_NO_SKELETON_MESHES_get();
  public static readonly string AI_CONFIG_PP_SBBC_MAX_BONES = assimp_swigPINVOKE.AI_CONFIG_PP_SBBC_MAX_BONES_get();
  public static readonly int AI_SBBC_DEFAULT_MAX_BONES = assimp_swigPINVOKE.AI_SBBC_DEFAULT_MAX_BONES_get();
  public static readonly string AI_CONFIG_PP_CT_MAX_SMOOTHING_ANGLE = assimp_swigPINVOKE.AI_CONFIG_PP_CT_MAX_SMOOTHING_ANGLE_get();
  public static readonly string AI_CONFIG_PP_CT_TEXTURE_CHANNEL_INDEX = assimp_swigPINVOKE.AI_CONFIG_PP_CT_TEXTURE_CHANNEL_INDEX_get();
  public static readonly string AI_CONFIG_PP_GSN_MAX_SMOOTHING_ANGLE = assimp_swigPINVOKE.AI_CONFIG_PP_GSN_MAX_SMOOTHING_ANGLE_get();
  public static readonly string AI_CONFIG_IMPORT_MDL_COLORMAP = assimp_swigPINVOKE.AI_CONFIG_IMPORT_MDL_COLORMAP_get();
  public static readonly string AI_CONFIG_PP_RRM_EXCLUDE_LIST = assimp_swigPINVOKE.AI_CONFIG_PP_RRM_EXCLUDE_LIST_get();
  public static readonly string AI_CONFIG_PP_PTV_KEEP_HIERARCHY = assimp_swigPINVOKE.AI_CONFIG_PP_PTV_KEEP_HIERARCHY_get();
  public static readonly string AI_CONFIG_PP_PTV_NORMALIZE = assimp_swigPINVOKE.AI_CONFIG_PP_PTV_NORMALIZE_get();
  public static readonly string AI_CONFIG_PP_PTV_ADD_ROOT_TRANSFORMATION = assimp_swigPINVOKE.AI_CONFIG_PP_PTV_ADD_ROOT_TRANSFORMATION_get();
  public static readonly string AI_CONFIG_PP_PTV_ROOT_TRANSFORMATION = assimp_swigPINVOKE.AI_CONFIG_PP_PTV_ROOT_TRANSFORMATION_get();
  public static readonly string AI_CONFIG_PP_FD_REMOVE = assimp_swigPINVOKE.AI_CONFIG_PP_FD_REMOVE_get();
  public static readonly string AI_CONFIG_PP_FD_CHECKAREA = assimp_swigPINVOKE.AI_CONFIG_PP_FD_CHECKAREA_get();
  public static readonly string AI_CONFIG_PP_OG_EXCLUDE_LIST = assimp_swigPINVOKE.AI_CONFIG_PP_OG_EXCLUDE_LIST_get();
  public static readonly string AI_CONFIG_PP_SLM_TRIANGLE_LIMIT = assimp_swigPINVOKE.AI_CONFIG_PP_SLM_TRIANGLE_LIMIT_get();
  public static readonly int AI_SLM_DEFAULT_MAX_TRIANGLES = assimp_swigPINVOKE.AI_SLM_DEFAULT_MAX_TRIANGLES_get();
  public static readonly string AI_CONFIG_PP_SLM_VERTEX_LIMIT = assimp_swigPINVOKE.AI_CONFIG_PP_SLM_VERTEX_LIMIT_get();
  public static readonly int AI_SLM_DEFAULT_MAX_VERTICES = assimp_swigPINVOKE.AI_SLM_DEFAULT_MAX_VERTICES_get();
  public static readonly string AI_CONFIG_PP_LBW_MAX_WEIGHTS = assimp_swigPINVOKE.AI_CONFIG_PP_LBW_MAX_WEIGHTS_get();
  public static readonly int AI_LMW_MAX_WEIGHTS = assimp_swigPINVOKE.AI_LMW_MAX_WEIGHTS_get();
  public static readonly string AI_CONFIG_PP_DB_THRESHOLD = assimp_swigPINVOKE.AI_CONFIG_PP_DB_THRESHOLD_get();
  public static readonly double AI_DEBONE_THRESHOLD = assimp_swigPINVOKE.AI_DEBONE_THRESHOLD_get();
  public static readonly string AI_CONFIG_PP_DB_ALL_OR_NONE = assimp_swigPINVOKE.AI_CONFIG_PP_DB_ALL_OR_NONE_get();
  public static readonly int PP_ICL_PTCACHE_SIZE = assimp_swigPINVOKE.PP_ICL_PTCACHE_SIZE_get();
  public static readonly string AI_CONFIG_PP_ICL_PTCACHE_SIZE = assimp_swigPINVOKE.AI_CONFIG_PP_ICL_PTCACHE_SIZE_get();
  public static readonly string AI_CONFIG_PP_RVC_FLAGS = assimp_swigPINVOKE.AI_CONFIG_PP_RVC_FLAGS_get();
  public static readonly string AI_CONFIG_PP_SBP_REMOVE = assimp_swigPINVOKE.AI_CONFIG_PP_SBP_REMOVE_get();
  public static readonly string AI_CONFIG_PP_FID_ANIM_ACCURACY = assimp_swigPINVOKE.AI_CONFIG_PP_FID_ANIM_ACCURACY_get();
  public static readonly string AI_CONFIG_PP_FID_IGNORE_TEXTURECOORDS = assimp_swigPINVOKE.AI_CONFIG_PP_FID_IGNORE_TEXTURECOORDS_get();
  public static readonly int AI_UVTRAFO_SCALING = assimp_swigPINVOKE.AI_UVTRAFO_SCALING_get();
  public static readonly int AI_UVTRAFO_ROTATION = assimp_swigPINVOKE.AI_UVTRAFO_ROTATION_get();
  public static readonly int AI_UVTRAFO_TRANSLATION = assimp_swigPINVOKE.AI_UVTRAFO_TRANSLATION_get();
  public static readonly int AI_UVTRAFO_ALL = assimp_swigPINVOKE.AI_UVTRAFO_ALL_get();
  public static readonly string AI_CONFIG_PP_TUV_EVALUATE = assimp_swigPINVOKE.AI_CONFIG_PP_TUV_EVALUATE_get();
  public static readonly string AI_CONFIG_FAVOUR_SPEED = assimp_swigPINVOKE.AI_CONFIG_FAVOUR_SPEED_get();
  public static readonly string AI_CONFIG_IMPORT_FBX_READ_ALL_GEOMETRY_LAYERS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_FBX_READ_ALL_GEOMETRY_LAYERS_get();
  public static readonly string AI_CONFIG_IMPORT_FBX_READ_ALL_MATERIALS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_FBX_READ_ALL_MATERIALS_get();
  public static readonly string AI_CONFIG_IMPORT_FBX_READ_MATERIALS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_FBX_READ_MATERIALS_get();
  public static readonly string AI_CONFIG_IMPORT_FBX_READ_TEXTURES = assimp_swigPINVOKE.AI_CONFIG_IMPORT_FBX_READ_TEXTURES_get();
  public static readonly string AI_CONFIG_IMPORT_FBX_READ_CAMERAS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_FBX_READ_CAMERAS_get();
  public static readonly string AI_CONFIG_IMPORT_FBX_READ_LIGHTS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_FBX_READ_LIGHTS_get();
  public static readonly string AI_CONFIG_IMPORT_FBX_READ_ANIMATIONS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_FBX_READ_ANIMATIONS_get();
  public static readonly string AI_CONFIG_IMPORT_FBX_STRICT_MODE = assimp_swigPINVOKE.AI_CONFIG_IMPORT_FBX_STRICT_MODE_get();
  public static readonly string AI_CONFIG_IMPORT_FBX_PRESERVE_PIVOTS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_FBX_PRESERVE_PIVOTS_get();
  public static readonly string AI_CONFIG_IMPORT_FBX_OPTIMIZE_EMPTY_ANIMATION_CURVES = assimp_swigPINVOKE.AI_CONFIG_IMPORT_FBX_OPTIMIZE_EMPTY_ANIMATION_CURVES_get();
  public static readonly string AI_CONFIG_IMPORT_FBX_EMBEDDED_TEXTURES_LEGACY_NAMING = assimp_swigPINVOKE.AI_CONFIG_IMPORT_FBX_EMBEDDED_TEXTURES_LEGACY_NAMING_get();
  public static readonly string AI_CONFIG_IMPORT_REMOVE_EMPTY_BONES = assimp_swigPINVOKE.AI_CONFIG_IMPORT_REMOVE_EMPTY_BONES_get();
  public static readonly string AI_CONFIG_FBX_CONVERT_TO_M = assimp_swigPINVOKE.AI_CONFIG_FBX_CONVERT_TO_M_get();
  public static readonly string AI_CONFIG_IMPORT_GLOBAL_KEYFRAME = assimp_swigPINVOKE.AI_CONFIG_IMPORT_GLOBAL_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_MD3_KEYFRAME = assimp_swigPINVOKE.AI_CONFIG_IMPORT_MD3_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_MD2_KEYFRAME = assimp_swigPINVOKE.AI_CONFIG_IMPORT_MD2_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_MDL_KEYFRAME = assimp_swigPINVOKE.AI_CONFIG_IMPORT_MDL_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_MDC_KEYFRAME = assimp_swigPINVOKE.AI_CONFIG_IMPORT_MDC_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_SMD_KEYFRAME = assimp_swigPINVOKE.AI_CONFIG_IMPORT_SMD_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_UNREAL_KEYFRAME = assimp_swigPINVOKE.AI_CONFIG_IMPORT_UNREAL_KEYFRAME_get();
  public static readonly string AI_CONFIG_IMPORT_SMD_LOAD_ANIMATION_LIST = assimp_swigPINVOKE.AI_CONFIG_IMPORT_SMD_LOAD_ANIMATION_LIST_get();
  public static readonly string AI_CONFIG_IMPORT_AC_SEPARATE_BFCULL = assimp_swigPINVOKE.AI_CONFIG_IMPORT_AC_SEPARATE_BFCULL_get();
  public static readonly string AI_CONFIG_IMPORT_AC_EVAL_SUBDIVISION = assimp_swigPINVOKE.AI_CONFIG_IMPORT_AC_EVAL_SUBDIVISION_get();
  public static readonly string AI_CONFIG_IMPORT_UNREAL_HANDLE_FLAGS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_UNREAL_HANDLE_FLAGS_get();
  public static readonly string AI_CONFIG_IMPORT_TER_MAKE_UVS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_TER_MAKE_UVS_get();
  public static readonly string AI_CONFIG_IMPORT_ASE_RECONSTRUCT_NORMALS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_ASE_RECONSTRUCT_NORMALS_get();
  public static readonly string AI_CONFIG_IMPORT_MD3_HANDLE_MULTIPART = assimp_swigPINVOKE.AI_CONFIG_IMPORT_MD3_HANDLE_MULTIPART_get();
  public static readonly string AI_CONFIG_IMPORT_MD3_SKIN_NAME = assimp_swigPINVOKE.AI_CONFIG_IMPORT_MD3_SKIN_NAME_get();
  public static readonly string AI_CONFIG_IMPORT_MD3_SHADER_SRC = assimp_swigPINVOKE.AI_CONFIG_IMPORT_MD3_SHADER_SRC_get();
  public static readonly string AI_CONFIG_IMPORT_LWO_ONE_LAYER_ONLY = assimp_swigPINVOKE.AI_CONFIG_IMPORT_LWO_ONE_LAYER_ONLY_get();
  public static readonly string AI_CONFIG_IMPORT_MD5_NO_ANIM_AUTOLOAD = assimp_swigPINVOKE.AI_CONFIG_IMPORT_MD5_NO_ANIM_AUTOLOAD_get();
  public static readonly string AI_CONFIG_IMPORT_LWS_ANIM_START = assimp_swigPINVOKE.AI_CONFIG_IMPORT_LWS_ANIM_START_get();
  public static readonly string AI_CONFIG_IMPORT_LWS_ANIM_END = assimp_swigPINVOKE.AI_CONFIG_IMPORT_LWS_ANIM_END_get();
  public static readonly string AI_CONFIG_IMPORT_IRR_ANIM_FPS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_IRR_ANIM_FPS_get();
  public static readonly string AI_CONFIG_IMPORT_OGRE_MATERIAL_FILE = assimp_swigPINVOKE.AI_CONFIG_IMPORT_OGRE_MATERIAL_FILE_get();
  public static readonly string AI_CONFIG_IMPORT_OGRE_TEXTURETYPE_FROM_FILENAME = assimp_swigPINVOKE.AI_CONFIG_IMPORT_OGRE_TEXTURETYPE_FROM_FILENAME_get();
  public static readonly string AI_CONFIG_ANDROID_JNI_ASSIMP_MANAGER_SUPPORT = assimp_swigPINVOKE.AI_CONFIG_ANDROID_JNI_ASSIMP_MANAGER_SUPPORT_get();
  public static readonly string AI_CONFIG_IMPORT_IFC_SKIP_SPACE_REPRESENTATIONS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_IFC_SKIP_SPACE_REPRESENTATIONS_get();
  public static readonly string AI_CONFIG_IMPORT_IFC_CUSTOM_TRIANGULATION = assimp_swigPINVOKE.AI_CONFIG_IMPORT_IFC_CUSTOM_TRIANGULATION_get();
  public static readonly string AI_CONFIG_IMPORT_IFC_SMOOTHING_ANGLE = assimp_swigPINVOKE.AI_CONFIG_IMPORT_IFC_SMOOTHING_ANGLE_get();
  public static readonly double AI_IMPORT_IFC_DEFAULT_SMOOTHING_ANGLE = assimp_swigPINVOKE.AI_IMPORT_IFC_DEFAULT_SMOOTHING_ANGLE_get();
  public static readonly string AI_CONFIG_IMPORT_IFC_CYLINDRICAL_TESSELLATION = assimp_swigPINVOKE.AI_CONFIG_IMPORT_IFC_CYLINDRICAL_TESSELLATION_get();
  public static readonly int AI_IMPORT_IFC_DEFAULT_CYLINDRICAL_TESSELLATION = assimp_swigPINVOKE.AI_IMPORT_IFC_DEFAULT_CYLINDRICAL_TESSELLATION_get();
  public static readonly string AI_CONFIG_IMPORT_COLLADA_IGNORE_UP_DIRECTION = assimp_swigPINVOKE.AI_CONFIG_IMPORT_COLLADA_IGNORE_UP_DIRECTION_get();
  public static readonly string AI_CONFIG_IMPORT_COLLADA_USE_COLLADA_NAMES = assimp_swigPINVOKE.AI_CONFIG_IMPORT_COLLADA_USE_COLLADA_NAMES_get();
  public static readonly string AI_CONFIG_IMPORT_3DXML_USE_COMPLEX_MATERIALS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_3DXML_USE_COMPLEX_MATERIALS_get();
  public static readonly string AI_CONFIG_IMPORT_3DXML_USE_NODE_MATERIALS = assimp_swigPINVOKE.AI_CONFIG_IMPORT_3DXML_USE_NODE_MATERIALS_get();
  public static readonly string AI_CONFIG_IMPORT_3DXML_USE_REFERENCES_NAMES = assimp_swigPINVOKE.AI_CONFIG_IMPORT_3DXML_USE_REFERENCES_NAMES_get();
  public static readonly string AI_CONFIG_EXPORT_XFILE_64BIT = assimp_swigPINVOKE.AI_CONFIG_EXPORT_XFILE_64BIT_get();
  public static readonly string AI_CONFIG_EXPORT_POINT_CLOUDS = assimp_swigPINVOKE.AI_CONFIG_EXPORT_POINT_CLOUDS_get();
  public static readonly string AI_CONFIG_GLOBAL_SCALE_FACTOR_KEY = assimp_swigPINVOKE.AI_CONFIG_GLOBAL_SCALE_FACTOR_KEY_get();
  public static readonly double AI_CONFIG_GLOBAL_SCALE_FACTOR_DEFAULT = assimp_swigPINVOKE.AI_CONFIG_GLOBAL_SCALE_FACTOR_DEFAULT_get();
  public static readonly string AI_CONFIG_APP_SCALE_KEY = assimp_swigPINVOKE.AI_CONFIG_APP_SCALE_KEY_get();
  public static readonly int ASSIMP_CFLAGS_SHARED = assimp_swigPINVOKE.ASSIMP_CFLAGS_SHARED_get();
  public static readonly int ASSIMP_CFLAGS_STLPORT = assimp_swigPINVOKE.ASSIMP_CFLAGS_STLPORT_get();
  public static readonly int ASSIMP_CFLAGS_DEBUG = assimp_swigPINVOKE.ASSIMP_CFLAGS_DEBUG_get();
  public static readonly int ASSIMP_CFLAGS_NOBOOST = assimp_swigPINVOKE.ASSIMP_CFLAGS_NOBOOST_get();
  public static readonly int ASSIMP_CFLAGS_SINGLETHREADED = assimp_swigPINVOKE.ASSIMP_CFLAGS_SINGLETHREADED_get();
  public static readonly int AI_SCENE_FLAGS_INCOMPLETE = assimp_swigPINVOKE.AI_SCENE_FLAGS_INCOMPLETE_get();
  public static readonly int AI_SCENE_FLAGS_VALIDATED = assimp_swigPINVOKE.AI_SCENE_FLAGS_VALIDATED_get();
  public static readonly int AI_SCENE_FLAGS_VALIDATION_WARNING = assimp_swigPINVOKE.AI_SCENE_FLAGS_VALIDATION_WARNING_get();
  public static readonly int AI_SCENE_FLAGS_NON_VERBOSE_FORMAT = assimp_swigPINVOKE.AI_SCENE_FLAGS_NON_VERBOSE_FORMAT_get();
  public static readonly int AI_SCENE_FLAGS_TERRAIN = assimp_swigPINVOKE.AI_SCENE_FLAGS_TERRAIN_get();
  public static readonly int AI_SCENE_FLAGS_ALLOW_SHARED = assimp_swigPINVOKE.AI_SCENE_FLAGS_ALLOW_SHARED_get();
  public static readonly int AI_MAX_FACE_INDICES = assimp_swigPINVOKE.AI_MAX_FACE_INDICES_get();
  public static readonly int AI_MAX_BONE_WEIGHTS = assimp_swigPINVOKE.AI_MAX_BONE_WEIGHTS_get();
  public static readonly int AI_MAX_VERTICES = assimp_swigPINVOKE.AI_MAX_VERTICES_get();
  public static readonly int AI_MAX_FACES = assimp_swigPINVOKE.AI_MAX_FACES_get();
  public static readonly int AI_MAX_NUMBER_OF_COLOR_SETS = assimp_swigPINVOKE.AI_MAX_NUMBER_OF_COLOR_SETS_get();
  public static readonly int AI_MAX_NUMBER_OF_TEXTURECOORDS = assimp_swigPINVOKE.AI_MAX_NUMBER_OF_TEXTURECOORDS_get();
  public static readonly string AI_DEFAULT_MATERIAL_NAME = assimp_swigPINVOKE.AI_DEFAULT_MATERIAL_NAME_get();
  public static readonly string _AI_MATKEY_TEXTURE_BASE = assimp_swigPINVOKE._AI_MATKEY_TEXTURE_BASE_get();
  public static readonly string _AI_MATKEY_UVWSRC_BASE = assimp_swigPINVOKE._AI_MATKEY_UVWSRC_BASE_get();
  public static readonly string _AI_MATKEY_TEXOP_BASE = assimp_swigPINVOKE._AI_MATKEY_TEXOP_BASE_get();
  public static readonly string _AI_MATKEY_MAPPING_BASE = assimp_swigPINVOKE._AI_MATKEY_MAPPING_BASE_get();
  public static readonly string _AI_MATKEY_TEXBLEND_BASE = assimp_swigPINVOKE._AI_MATKEY_TEXBLEND_BASE_get();
  public static readonly string _AI_MATKEY_MAPPINGMODE_U_BASE = assimp_swigPINVOKE._AI_MATKEY_MAPPINGMODE_U_BASE_get();
  public static readonly string _AI_MATKEY_MAPPINGMODE_V_BASE = assimp_swigPINVOKE._AI_MATKEY_MAPPINGMODE_V_BASE_get();
  public static readonly string _AI_MATKEY_TEXMAP_AXIS_BASE = assimp_swigPINVOKE._AI_MATKEY_TEXMAP_AXIS_BASE_get();
  public static readonly string _AI_MATKEY_UVTRANSFORM_BASE = assimp_swigPINVOKE._AI_MATKEY_UVTRANSFORM_BASE_get();
  public static readonly string _AI_MATKEY_TEXFLAGS_BASE = assimp_swigPINVOKE._AI_MATKEY_TEXFLAGS_BASE_get();
  public static readonly string AI_EMBEDDED_TEXNAME_PREFIX = assimp_swigPINVOKE.AI_EMBEDDED_TEXNAME_PREFIX_get();
  public static readonly int HINTMAXTEXTURELEN = assimp_swigPINVOKE.HINTMAXTEXTURELEN_get();
  public static readonly int AI_PROPERTY_WAS_NOT_EXISTING = assimp_swigPINVOKE.AI_PROPERTY_WAS_NOT_EXISTING_get();
  public static readonly int AI_FALSE = assimp_swigPINVOKE.AI_FALSE_get();
  public static readonly int AI_TRUE = assimp_swigPINVOKE.AI_TRUE_get();
  public static readonly uint MAX_LOG_MESSAGE_LENGTH = assimp_swigPINVOKE.MAX_LOG_MESSAGE_LENGTH_get();
  public static readonly string ASSIMP_DEFAULT_LOG_NAME = assimp_swigPINVOKE.ASSIMP_DEFAULT_LOG_NAME_get();
}

}
