const axios = require("axios");
const draftEndpoint = process.env.VUE_APP_API + "draft/";
const draftLookupsEndpoint = draftEndpoint + "lookups";

class DraftService {
  constructor() {
    axios.baseUrl = process.env.VUE_APP_API;
    axios.defaults.withCredentials = true;
  }

  async createDraft(entity) {
    const apiCall = await axios.post(draftEndpoint, entity, {
      headers: {
        "Access-Control-Allow-Origin": "http://localhost:8080/"
      }
    });
    return apiCall;
  }

  async getDrafts() {
    const apiCall = await axios.get(draftEndpoint, {
      headers: {
        "Access-Control-Allow-Origin": "http://localhost:8080/"
      }
    });
    return apiCall;
  }

  async getDraftLookups() {
    const apiCall = await axios.get(draftLookupsEndpoint, {
      headers: {
        "Access-Control-Allow-Origin": "http://localhost:8080/"
      }
    });
    return apiCall;
  }
}

export default DraftService;
