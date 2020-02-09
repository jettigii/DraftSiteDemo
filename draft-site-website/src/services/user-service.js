const axios = require("axios");
const usersEndpoint = "user/";
const authenticatePath = `${usersEndpoint}authenticate`;

class UserService {
  constructor() {
    this.url = process.env.VUE_APP_API;
    axios.defaults.withCredentials = true;
  }

  /**
   * User Login.
   * @param {A entity Object} entity
   */
  async authenticate(entity) {
    const apiCall = await axios.post(this.url + authenticatePath, entity, {
      headers: {
        "Access-Control-Allow-Origin": "http://localhost:8080/",
        "XMLHttpRequest.withCredentials": true
      }
    });
    return apiCall;
  }
}

export default UserService;
